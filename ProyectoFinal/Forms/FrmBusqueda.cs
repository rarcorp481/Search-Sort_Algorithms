using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
                    // Límite visual para no congelar la UI
                    if (i < 2000) lstNumeros.Items.Add(val);
                }
                lstNumeros.EndUpdate();
            }
            else
            {
                MessageBox.Show("Ingrese una cantidad válida (sólo números enteros > 0).");
            }
        }

        private void BtnLineal_Click(object sender, EventArgs e)
        {
            if (numeros.Count == 0 || !int.TryParse(txtBuscarLineal.Text, out int objetivo)) return;

            Stopwatch sw = Stopwatch.StartNew();
            long memoriaInicial = GC.GetTotalMemory(true);

            int indice = -1;
            for (int i = 0; i < numeros.Count; i++)
            {
                if (numeros[i] == objetivo)
                {
                    indice = i;
                    break;
                }
            }

            sw.Stop();
            long memoriaFinal = GC.GetTotalMemory(true);

            // Medición en segundos
            double segundos = sw.Elapsed.TotalSeconds;

            string resultado = indice != -1 ? "Encontrado" : "No Encontrado";
            // Usamos F7 para mostrar suficientes decimales en segundos
            lblResLineal.Text = $"Estado: {resultado}\nTiempo: {segundos:F7} s\nMemoria: {(memoriaFinal - memoriaInicial)} bytes";

            if (indice != -1 && indice < lstNumeros.Items.Count)
                lstNumeros.SelectedIndex = indice;

            GuardarResultado("Lineal", numeros.Count, segundos);
        }

        private void BtnBinaria_Click(object sender, EventArgs e)
        {
            if (numeros.Count == 0 || !int.TryParse(txtBuscarBinaria.Text, out int objetivo)) return;

            List<int> copiaOrdenada = new List<int>(numeros);
            copiaOrdenada.Sort();

            Stopwatch sw = Stopwatch.StartNew();
            long memoriaInicial = GC.GetTotalMemory(true);

            int indice = copiaOrdenada.BinarySearch(objetivo);

            sw.Stop();
            long memoriaFinal = GC.GetTotalMemory(true);

            // Medición en segundos
            double segundos = sw.Elapsed.TotalSeconds;

            string resultado = indice >= 0 ? "Encontrado" : "No Encontrado";
            lblResBinaria.Text = $"Estado: {resultado}\nTiempo: {segundos:F7} s\nMemoria: {(memoriaFinal - memoriaInicial)} bytes";

            if (indice >= 0)
            {
                int visualIndex = numeros.IndexOf(objetivo);
                if (visualIndex != -1 && visualIndex < lstNumeros.Items.Count)
                    lstNumeros.SelectedIndex = visualIndex;
            }

            GuardarResultado("Binaria", numeros.Count, segundos);
        }

        private void GuardarResultado(string nombre, int cant, double tiempoSeg)
        {
            DatosGlobales.Resultados.Add(new ResultadoAlgoritmo
            {
                Nombre = nombre,
                CantidadElementos = cant,
                TiempoSegundos = tiempoSeg, // Guardamos en segundos
                Tipo = "Busqueda"
            });
        }

        private void FrmBusqueda_Load(object sender, EventArgs e)
        {

        }
    }
}