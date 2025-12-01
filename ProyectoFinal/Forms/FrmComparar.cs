using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScottPlot;

namespace ProyectoFinal.Forms
{
    public partial class FrmComparar : Form
    {
        public FrmComparar()
        {
            InitializeComponent();
            this.BackColor = DatosGlobales.ColorFondo;

            ConfigurarPlot(plotLineal, "Búsqueda Lineal (O(n))");
            ConfigurarPlot(plotBinaria, "Búsqueda Binaria (O(log n))");
            ConfigurarPlot(plotInsertion, "Insertion Sort (O(n²))");
            ConfigurarPlot(plotQuick, "Quick Sort (O(n log n))");
        }

        private void ConfigurarPlot(ScottPlot.WinForms.FormsPlot plot, string titulo)
        {
            plot.Plot.Title(titulo);
            plot.Plot.Axes.Bottom.Label.Text = "N (Elementos)";
            plot.Plot.Axes.Left.Label.Text = "Pasos";
            plot.Plot.Grid.MajorLineColor = ScottPlot.Color.FromHex("#E0E0E0");
        }

        private async void BtnBenchmark_Click(object sender, EventArgs e)
        {
            btnBenchmark.Enabled = false;
            btnBenchmark.Text = "Procesando...";
            DatosGlobales.Resultados.Clear();

            // Generamos puntos para la curva (100 a 10,000)
            List<int> cantidades = new List<int>();
            for (int i = 100; i <= 10000; i += 150) cantidades.Add(i);

            await Task.Run(() =>
            {
                foreach (int n in cantidades)
                {
                    List<int> datos = GenerarLista(n);

                    // BUSQUEDA (Peor caso: Buscar -1)
                    Guardar("Lineal", n, TestLineal(datos, -1), "Busqueda");

                    List<int> ordenada = new List<int>(datos);
                    ordenada.Sort();
                    Guardar("Binaria", n, TestBinaria(ordenada, -1), "Busqueda");

                    // ORDENAMIENTO
                    if (n <= 6000) // Límite para Insertion
                        Guardar("Insertion Sort", n, TestInsertion(new List<int>(datos)), "Ordenamiento");

                    Guardar("Quick Sort", n, TestQuick(new List<int>(datos)), "Ordenamiento");
                }
            });

            ActualizarGrafica();
            btnBenchmark.Text = "Ejecutar Benchmark";
            btnBenchmark.Enabled = true;
        }

        private void ActualizarGrafica()
        {
            var datos = DatosGlobales.Resultados;

            DibujarCurva(plotLineal, datos, "Lineal", ScottPlot.Colors.Blue);
            DibujarCurva(plotBinaria, datos, "Binaria", ScottPlot.Colors.Green);
            DibujarCurva(plotInsertion, datos, "Insertion Sort", ScottPlot.Colors.Red);
            DibujarCurva(plotQuick, datos, "Quick Sort", ScottPlot.Colors.Orange);

            plotLineal.Refresh();
            plotBinaria.Refresh();
            plotInsertion.Refresh();
            plotQuick.Refresh();
        }

        private void DibujarCurva(ScottPlot.WinForms.FormsPlot plot, List<ResultadoAlgoritmo> datos, string nombre, ScottPlot.Color color)
        {
            plot.Plot.Clear();
            var puntos = datos.Where(x => x.Nombre == nombre).OrderBy(x => x.CantidadElementos).ToList();
            if (puntos.Count == 0) return;

            double[] xs = puntos.Select(p => (double)p.CantidadElementos).ToArray();
            double[] ys = puntos.Select(p => (double)p.Pasos).ToArray();

            var linea = plot.Plot.Add.Scatter(xs, ys);
            linea.Color = color;
            linea.LineWidth = 3;
            linea.MarkerSize = 0; // Sin puntos, solo línea limpia

            plot.Plot.Axes.AutoScale();
        }

        private void Guardar(string nombre, int n, long pasos, string tipo)
        {
            DatosGlobales.Resultados.Add(new ResultadoAlgoritmo { Nombre = nombre, CantidadElementos = n, Pasos = pasos, Tipo = tipo });
        }

        // --- ALGORITMOS INTERNOS (BENCHMARK) ---
        private List<int> GenerarLista(int n)
        {
            Random rnd = new Random();
            List<int> l = new List<int>();
            for (int i = 0; i < n; i++) l.Add(rnd.Next(0, n * 2));
            return l;
        }

        private long TestLineal(List<int> l, int obj)
        {
            long p = 0;
            foreach (var n in l) { p++; if (n == obj) break; }
            return p;
        }

        private long TestBinaria(List<int> l, int obj)
        {
            long p = 0;
            int i = 0, d = l.Count - 1;
            while (i <= d)
            {
                p++;
                int m = i + (d - i) / 2;
                if (l[m] == obj) break;
                if (l[m] < obj) i = m + 1; else d = m - 1;
            }
            return p;
        }

        private long TestInsertion(List<int> l)
        {
            long p = 0;
            for (int i = 1; i < l.Count; i++)
            {
                int k = l[i], j = i - 1;
                while (j >= 0)
                {
                    p++;
                    if (l[j] > k) { l[j + 1] = l[j]; j--; } else break;
                }
                l[j + 1] = k;
            }
            return p;
        }

        private long TestQuick(List<int> l)
        {
            long p = 0;
            QuickRec(l, 0, l.Count - 1, ref p);
            return p;
        }

        private void QuickRec(List<int> arr, int low, int high, ref long p)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high, ref p);
                QuickRec(arr, low, pi - 1, ref p);
                QuickRec(arr, pi + 1, high, ref p);
            }
        }

        private int Partition(List<int> arr, int low, int high, ref long p)
        {
            int pivot = arr[high], i = low - 1;
            for (int j = low; j < high; j++)
            {
                p++;
                if (arr[j] < pivot)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }
            (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
            return i + 1;
        }
    }
}