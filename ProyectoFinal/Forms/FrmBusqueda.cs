using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Forms
{
    public partial class FrmBusqueda : Form
    {
        private List<int> numeros = new List<int>();

        public FrmBusqueda()
        {
            InitializeComponent();
            this.BackColor = DatosGlobales.ColorFondo;
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCantidad.Text, out int n) && n > 0)
            {
                Random rnd = new Random();
                numeros.Clear();
                lstNumeros.Items.Clear();

                lstNumeros.BeginUpdate();
                for (int i = 0; i < n; i++)
                {
                    int val = rnd.Next(0, 501);
                    numeros.Add(val);
                    if (i < 2000) lstNumeros.Items.Add(val);
                }
                lstNumeros.EndUpdate();
            }
            else MessageBox.Show("Ingrese cantidad válida.");
        }

        private async void BtnLineal_Click(object sender, EventArgs e)
        {
            if (numeros.Count == 0 || !int.TryParse(txtBuscar.Text, out int objetivo)) return;

            btnLineal.Enabled = false;
            lblResLineal.Text = "Contando pasos...";

            var resultado = await Task.Run(() =>
            {
                long pasos = 0;
                long memInicio = GC.GetAllocatedBytesForCurrentThread();
                Stopwatch sw = Stopwatch.StartNew();

                int idx = -1;
                for (int i = 0; i < numeros.Count; i++)
                {
                    pasos++; // CADA COMPARACIÓN ES UN PASO
                    if (numeros[i] == objetivo)
                    {
                        idx = i;
                        break;
                    }
                }

                sw.Stop();
                long memFin = GC.GetAllocatedBytesForCurrentThread();

                return new { Indice = idx, Tiempo = sw.Elapsed.TotalSeconds, Memoria = memFin - memInicio, Pasos = pasos };
            });

            string textoEstado = resultado.Indice != -1 ? "Encontrado" : "No Encontrado";

            // Mostramos PASOS en lugar de solo tiempo
            lblResLineal.Text = $"Estado: {textoEstado}\nPasos: {resultado.Pasos:N0}\nMemoria: {resultado.Memoria:N0} bytes";

            if (resultado.Indice != -1 && resultado.Indice < lstNumeros.Items.Count)
                lstNumeros.SelectedIndex = resultado.Indice;

            Guardar("Lineal", numeros.Count, resultado.Tiempo, resultado.Pasos);
            btnLineal.Enabled = true;
        }

        private async void BtnBinaria_Click(object sender, EventArgs e)
        {
            if (numeros.Count == 0 || !int.TryParse(txtBuscar.Text, out int objetivo)) return;

            btnBinaria.Enabled = false;
            lblResBinaria.Text = "Contando pasos...";

            var resultado = await Task.Run(() =>
            {
                long pasos = 0;
                long memInicio = GC.GetAllocatedBytesForCurrentThread();
                Stopwatch sw = Stopwatch.StartNew();

                List<int> copia = new List<int>(numeros);
                copia.Sort(); // Ordenar no cuenta para la búsqueda binaria pura, solo el while

                int izquierda = 0;
                int derecha = copia.Count - 1;
                int idx = -1;

                while (izquierda <= derecha)
                {
                    pasos++; // CADA DIVISIÓN ES UN PASO
                    int medio = izquierda + (derecha - izquierda) / 2;

                    if (copia[medio] == objetivo)
                    {
                        idx = medio;
                        break;
                    }
                    if (copia[medio] < objetivo)
                        izquierda = medio + 1;
                    else
                        derecha = medio - 1;
                }

                sw.Stop();
                long memFin = GC.GetAllocatedBytesForCurrentThread();

                return new { Indice = idx, Tiempo = sw.Elapsed.TotalSeconds, Memoria = memFin - memInicio, Pasos = pasos };
            });

            string textoEstado = resultado.Indice >= 0 ? "Encontrado" : "No Encontrado";
            lblResBinaria.Text = $"Estado: {textoEstado}\nPasos: {resultado.Pasos:N0}\nMemoria: {resultado.Memoria:N0} bytes";

            if (resultado.Indice >= 0)
            {
                int visualIdx = numeros.IndexOf(objetivo);
                if (visualIdx != -1 && visualIdx < lstNumeros.Items.Count) lstNumeros.SelectedIndex = visualIdx;
            }

            Guardar("Binaria", numeros.Count, resultado.Tiempo, resultado.Pasos);
            btnBinaria.Enabled = true;
        }

        private void Guardar(string nombre, int n, double t, long p)
        {
            DatosGlobales.Resultados.Add(new ResultadoAlgoritmo
            {
                Nombre = nombre,
                CantidadElementos = n,
                TiempoSegundos = t,
                Pasos = p, // Guardamos los pasos reales
                Tipo = "Busqueda"
            });
        }
    }
}