using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoFinal.Forms
{
    public partial class FrmOrdenamiento : Form
    {
        private List<int> listaOriginal = new List<int>();

        public FrmOrdenamiento()
        {
            InitializeComponent();
            this.BackColor = DatosGlobales.ColorFondo;
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCantidad.Text, out int n) && n > 0)
            {
                Random rnd = new Random();
                listaOriginal.Clear();
                lstOriginal.Items.Clear();
                lstInsertion.Items.Clear();
                lstQuick.Items.Clear();

                lstOriginal.BeginUpdate();
                for (int i = 0; i < n; i++)
                {
                    int val = rnd.Next(0, 501);
                    listaOriginal.Add(val);
                    if (i < 2000) lstOriginal.Items.Add(val);
                }
                lstOriginal.EndUpdate();
            }
            else
            {
                MessageBox.Show("Ingrese una cantidad válida.");
            }
        }

        // --- INSERTION SORT ---
        private void BtnInsertAsc_Click(object sender, EventArgs e) => EjecutarInsertion(true);
        private void BtnInsertDesc_Click(object sender, EventArgs e) => EjecutarInsertion(false);

        private void EjecutarInsertion(bool ascendente)
        {
            if (listaOriginal.Count == 0) return;
            if (listaOriginal.Count > 10000)
            {
                if (MessageBox.Show("Insertion Sort es muy lento con grandes cantidades. ¿Seguro?", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.No) return;
            }

            List<int> copia = new List<int>(listaOriginal);

            Stopwatch sw = Stopwatch.StartNew();
            long memoriaIni = GC.GetTotalMemory(true);

            for (int i = 1; i < copia.Count; i++)
            {
                int key = copia[i];
                int j = i - 1;
                while (j >= 0 && (ascendente ? copia[j] > key : copia[j] < key))
                {
                    copia[j + 1] = copia[j];
                    j = j - 1;
                }
                copia[j + 1] = key;
            }

            sw.Stop();
            long memoriaFin = GC.GetTotalMemory(true);

            ActualizarLista(lstInsertion, copia);

            // Medición en segundos
            double segundos = sw.Elapsed.TotalSeconds;
            lblResInsertion.Text = $"Tiempo: {segundos:F7} s\nMemoria: {memoriaFin - memoriaIni} bytes";

            DatosGlobales.Resultados.Add(new ResultadoAlgoritmo
            {
                Nombre = "Insertion Sort",
                CantidadElementos = listaOriginal.Count,
                TiempoSegundos = segundos,
                Tipo = "Ordenamiento"
            });
        }

        // --- QUICK SORT ---
        private void BtnQuickAsc_Click(object sender, EventArgs e) => EjecutarQuick(true);
        private void BtnQuickDesc_Click(object sender, EventArgs e) => EjecutarQuick(false);

        private void EjecutarQuick(bool ascendente)
        {
            if (listaOriginal.Count == 0) return;

            List<int> copia = new List<int>(listaOriginal);

            Stopwatch sw = Stopwatch.StartNew();
            long memoriaIni = GC.GetTotalMemory(true);

            QuickSortRecursivo(copia, 0, copia.Count - 1, ascendente);

            sw.Stop();
            long memoriaFin = GC.GetTotalMemory(true);

            ActualizarLista(lstQuick, copia);

            // Medición en segundos
            double segundos = sw.Elapsed.TotalSeconds;
            lblResQuick.Text = $"Tiempo: {segundos:F7} s\nMemoria: {memoriaFin - memoriaIni} bytes";

            DatosGlobales.Resultados.Add(new ResultadoAlgoritmo
            {
                Nombre = "Quick Sort",
                CantidadElementos = listaOriginal.Count,
                TiempoSegundos = segundos,
                Tipo = "Ordenamiento"
            });
        }

        private void QuickSortRecursivo(List<int> arr, int low, int high, bool ascendente)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high, ascendente);
                QuickSortRecursivo(arr, low, pi - 1, ascendente);
                QuickSortRecursivo(arr, pi + 1, high, ascendente);
            }
        }

        private int Partition(List<int> arr, int low, int high, bool ascendente)
        {
            int pivot = arr[high];
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (ascendente ? arr[j] < pivot : arr[j] > pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;
            return i + 1;
        }

        private void ActualizarLista(ListBox lst, List<int> datos)
        {
            lst.Items.Clear();
            lst.BeginUpdate();
            for (int i = 0; i < datos.Count && i < 2000; i++) lst.Items.Add(datos[i]);
            lst.EndUpdate();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}