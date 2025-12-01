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

        // Eventos de Botones

        // Generar Números (del 0 al 500)
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

        // Búsqueda Lineal
        private async void BtnLineal_Click(object sender, EventArgs e)
        {
            if (numeros.Count == 0 || !int.TryParse(txtBuscarLineal.Text, out int objetivo)) return;

            btnLineal.Enabled = false;
            lblResLineal.Text = "Buscando...";

            var resultado = await Task.Run(() =>
            {
                long memInicio = GC.GetAllocatedBytesForCurrentThread();
                Stopwatch sw = Stopwatch.StartNew();

                int idx = -1;
                for (int i = 0; i < numeros.Count; i++)
                {
                    if (numeros[i] == objetivo) { idx = i; break; }
                }

                sw.Stop();
                long memFin = GC.GetAllocatedBytesForCurrentThread();
                return new { Indice = idx, Tiempo = sw.Elapsed.TotalSeconds, Memoria = memFin - memInicio };
            });

            lblResLineal.Text = $"Estado: {(resultado.Indice != -1 ? "Encontrado" : "No Encontrado")}\nTiempo: {resultado.Tiempo:F7} s\nMemoria: {resultado.Memoria:N0} bytes";

            if (resultado.Indice != -1 && resultado.Indice < lstNumeros.Items.Count)
                lstNumeros.SelectedIndex = resultado.Indice;

            btnLineal.Enabled = true;
        }

        // Búsqueda Binaria
        private async void BtnBinaria_Click(object sender, EventArgs e)
        {
            if (numeros.Count == 0 || !int.TryParse(txtBuscarBinaria.Text, out int objetivo)) return;

            btnBinaria.Enabled = false;
            lblResBinaria.Text = "Procesando...";

            var resultado = await Task.Run(() =>
            {
                long memInicio = GC.GetAllocatedBytesForCurrentThread();
                Stopwatch sw = Stopwatch.StartNew();

                List<int> copia = new List<int>(numeros);
                copia.Sort();
                int idx = copia.BinarySearch(objetivo);

                sw.Stop();
                long memFin = GC.GetAllocatedBytesForCurrentThread();
                return new { Indice = idx, Tiempo = sw.Elapsed.TotalSeconds, Memoria = memFin - memInicio };
            });

            lblResBinaria.Text = $"Estado: {(resultado.Indice >= 0 ? "Encontrado" : "No Encontrado")}\nTiempo: {resultado.Tiempo:F7} s\nMemoria: {resultado.Memoria:N0} bytes";

            if (resultado.Indice >= 0)
            {
                int visualIdx = numeros.IndexOf(objetivo);
                if (visualIdx != -1 && visualIdx < lstNumeros.Items.Count) lstNumeros.SelectedIndex = visualIdx;
            }

            btnBinaria.Enabled = true;
        }
    }
}