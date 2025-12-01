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

            // Configurar Estilo de los 4 Gráficos Individuales
            ConfigurarPlot(plotLineal, "Búsqueda Lineal (O(n))");
            ConfigurarPlot(plotBinaria, "Búsqueda Binaria (O(log n))");
            ConfigurarPlot(plotInsertion, "Insertion Sort (O(n²))");
            ConfigurarPlot(plotQuick, "Quick Sort (O(n log n))");
        }

        private void ConfigurarPlot(ScottPlot.WinForms.FormsPlot plot, string titulo)
        {
            plot.Plot.Title(titulo);
            plot.Plot.Axes.Bottom.Label.Text = "Cantidad (N)";
            plot.Plot.Axes.Left.Label.Text = "Pasos (Operaciones)";
            plot.Plot.Grid.MajorLineColor = ScottPlot.Color.FromHex("#E0E0E0");
        }

        // Botón Benchmark para mostrar gráficas de las curvas de complejidad (o notación Big O)
        private async void BtnBenchmark_Click(object sender, EventArgs e)
        {
            btnBenchmark.Enabled = false;
            btnBenchmark.Text = "Ejecutando...";

            // Limpiamos datos viejos
            DatosGlobales.Resultados.Clear();

            // Cantidades para generar una curva suave
            List<int> cantidades = new List<int>();
            for (int i = 100; i <= 10000; i += 150)
            {
                cantidades.Add(i);
            }

            await Task.Run(() =>
            {
                foreach (int n in cantidades)
                {
                    // Generar Lista Aleatoria
                    List<int> datos = GenerarLista(n);

                    // --- BÚSQUEDA ---
                    // Se busca -1 (porque no está) para forzar el peor caso y mostrar la gráfica tal cual en la notación Big O lo representa
                    int objetivo = -1;

                    // Lineal
                    long pasosLineal = TestLineal(datos, objetivo);
                    Guardar("Lineal", n, pasosLineal, "Busqueda");

                    // Binaria
                    List<int> ordenada = new List<int>(datos);
                    ordenada.Sort();
                    long pasosBinaria = TestBinaria(ordenada, objetivo);
                    Guardar("Binaria", n, pasosBinaria, "Busqueda");

                    // --- ORDENAMIENTO ---
                    // Insertion (Limitado a 6000 para no congelar)
                    if (n <= 6000)
                    {
                        // Se ordena una lista desordenada, el peor caso es una aleatoria pero se puede visualizar la curva así
                        long pasosInsertion = TestInsertion(new List<int>(datos));
                        Guardar("Insertion Sort", n, pasosInsertion, "Ordenamiento");
                    }

                    // QuickSort
                    long pasosQuick = TestQuick(new List<int>(datos));
                    Guardar("Quick Sort", n, pasosQuick, "Ordenamiento");
                }
            });

            ActualizarGrafica();
            btnBenchmark.Text = "Test Finalizado";
            btnBenchmark.Enabled = true;
        }

        // --- ACTUALIZAR LAS 4 GRÁFICAS ---
        public void ActualizarGrafica()
        {
            // Limpiar
            plotLineal.Plot.Clear();
            plotBinaria.Plot.Clear();
            plotInsertion.Plot.Clear();
            plotQuick.Plot.Clear();

            var datos = DatosGlobales.Resultados;
            if (datos == null || datos.Count == 0) return;

            // Dibujar cada algoritmo en SU propio gráfico
            DibujarCurva(plotLineal, datos, "Lineal", ScottPlot.Colors.Blue);
            DibujarCurva(plotBinaria, datos, "Binaria", ScottPlot.Colors.Green);
            DibujarCurva(plotInsertion, datos, "Insertion Sort", ScottPlot.Colors.Red);
            DibujarCurva(plotQuick, datos, "Quick Sort", ScottPlot.Colors.Orange);

            // Refrescar todos los gráficos para mostrar cambios
            plotLineal.Refresh();
            plotBinaria.Refresh();
            plotInsertion.Refresh();
            plotQuick.Refresh();
        }

        private void DibujarCurva(ScottPlot.WinForms.FormsPlot plot, List<ResultadoAlgoritmo> totalDatos, string nombre, ScottPlot.Color color)
        {
            var puntos = totalDatos
                .Where(x => x.Nombre == nombre)
                .OrderBy(x => x.CantidadElementos)
                .ToList();

            if (puntos.Count == 0) return;

            double[] xs = puntos.Select(p => (double)p.CantidadElementos).ToArray();
            double[] ys = puntos.Select(p => (double)p.Pasos).ToArray(); // <--- Eje Y: PASOS

            // Usamos Scatter para dibujar línea + puntos
            var linea = plot.Plot.Add.Scatter(xs, ys);
            linea.Color = color;
            linea.LineWidth = 3;
            linea.MarkerSize = 5; // Puntos pequeños para que la curva se vea suave

            plot.Plot.Axes.AutoScale(); // Zoom automático
        }

        private void Guardar(string nombre, int n, long pasos, string tipo)
        {
            DatosGlobales.Resultados.Add(new ResultadoAlgoritmo
            {
                Nombre = nombre,
                CantidadElementos = n,
                Pasos = pasos,
                Tipo = tipo,
                TiempoSegundos = 0 // No se usa tiempo aquí
            });
        }

        // --- ALGORITMOS "SILENCIOSOS" PARA EL TEST --- (más condensados pero igual de funcionales para visualizar la gráfica)

        private List<int> GenerarLista(int n)
        {
            Random rnd = new Random();
            List<int> l = new List<int>();
            for (int i = 0; i < n; i++) l.Add(rnd.Next(0, n * 2));
            return l;
        }

        private long TestLineal(List<int> lista, int objetivo)
        {
            long pasos = 0;
            foreach (var num in lista)
            {
                pasos++;
                if (num == objetivo) break;
            }
            return pasos;
        }

        private long TestBinaria(List<int> ordenada, int objetivo)
        {
            long pasos = 0;
            int izq = 0, der = ordenada.Count - 1;
            while (izq <= der)
            {
                pasos++;
                int medio = izq + (der - izq) / 2;
                if (ordenada[medio] == objetivo) break;
                if (ordenada[medio] < objetivo) izq = medio + 1;
                else der = medio - 1;
            }
            return pasos;
        }

        private long TestInsertion(List<int> lista)
        {
            long pasos = 0;
            for (int i = 1; i < lista.Count; i++)
            {
                int key = lista[i];
                int j = i - 1;
                while (j >= 0)
                {
                    pasos++;
                    if (lista[j] > key)
                    {
                        lista[j + 1] = lista[j];
                        j--;
                    }
                    else break;
                }
                lista[j + 1] = key;
            }
            return pasos;
        }

        private long TestQuick(List<int> lista)
        {
            long pasos = 0;
            QuickSortRec(lista, 0, lista.Count - 1, ref pasos);
            return pasos;
        }

        private void QuickSortRec(List<int> arr, int low, int high, ref long pasos)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high, ref pasos);
                QuickSortRec(arr, low, pi - 1, ref pasos);
                QuickSortRec(arr, pi + 1, high, ref pasos);
            }
        }

        private int Partition(List<int> arr, int low, int high, ref long pasos)
        {
            int pivot = arr[high];
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                pasos++;
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