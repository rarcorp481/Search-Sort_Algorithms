using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
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

        // Eventos de Botones

        // Generar Números (del 0 al 500)
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
        }

        // Insertion Sort
        private void BtnInsertAsc_Click(object sender, EventArgs e) => EjecutarInsertion(true);
        private void BtnInsertDesc_Click(object sender, EventArgs e) => EjecutarInsertion(false);

        // Métodos asíncronos para Insertion Sort
        private async void EjecutarInsertion(bool asc)
        {
            if (listaOriginal.Count == 0) return;
            if (listaOriginal.Count > 20000 && MessageBox.Show("Insertion Sort masivo detectado. ¿Seguir?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.No) return;

            btnInsertAsc.Enabled = false; btnInsertDesc.Enabled = false;
            lblResInsertion.Text = "Procesando...";

            var resultado = await Task.Run(() =>
            {
                long m1 = GC.GetAllocatedBytesForCurrentThread();
                Stopwatch sw = Stopwatch.StartNew();
                List<int> copia = new List<int>(listaOriginal);

                for (int i = 1; i < copia.Count; i++)
                {
                    int key = copia[i];
                    int j = i - 1;
                    while (j >= 0 && (asc ? copia[j] > key : copia[j] < key))
                    {
                        copia[j + 1] = copia[j];
                        j--;
                    }
                    copia[j + 1] = key;
                }

                sw.Stop();
                long m2 = GC.GetAllocatedBytesForCurrentThread();
                return new { Lista = copia, Tiempo = sw.Elapsed.TotalSeconds, Memoria = m2 - m1 };
            });

            ActualizarLista(lstInsertion, resultado.Lista);
            lblResInsertion.Text = $"Tiempo: {resultado.Tiempo:F7} s\nMemoria: {resultado.Memoria:N0} bytes";
            btnInsertAsc.Enabled = true; btnInsertDesc.Enabled = true;
        }

        // Quick Sort
        private void BtnQuickAsc_Click(object sender, EventArgs e) => EjecutarQuick(true);
        private void BtnQuickDesc_Click(object sender, EventArgs e) => EjecutarQuick(false);

        // Métodos asíncronos para Quick Sort
        private async void EjecutarQuick(bool asc)
        {
            if (listaOriginal.Count == 0) return;

            btnQuickAsc.Enabled = false; btnQuickDesc.Enabled = false;
            lblResQuick.Text = "Procesando...";

            var resultado = await Task.Run(() =>
            {
                long m1 = GC.GetAllocatedBytesForCurrentThread();
                Stopwatch sw = Stopwatch.StartNew();
                List<int> copia = new List<int>(listaOriginal);

                QuickSortRec(copia, 0, copia.Count - 1, asc);

                sw.Stop();
                long m2 = GC.GetAllocatedBytesForCurrentThread();
                return new { Lista = copia, Tiempo = sw.Elapsed.TotalSeconds, Memoria = m2 - m1 };
            });

            ActualizarLista(lstQuick, resultado.Lista);
            lblResQuick.Text = $"Tiempo: {resultado.Tiempo:F7} s\nMemoria: {resultado.Memoria:N0} bytes";
            btnQuickAsc.Enabled = true; btnQuickDesc.Enabled = true;
        }

        private void QuickSortRec(List<int> arr, int low, int high, bool asc)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high, asc);
                QuickSortRec(arr, low, pi - 1, asc);
                QuickSortRec(arr, pi + 1, high, asc);
            }
        }

        private int Partition(List<int> arr, int low, int high, bool asc)
        {
            int pivot = arr[high];
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (asc ? arr[j] < pivot : arr[j] > pivot)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }
            (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
            return i + 1;
        }

        // Actualizar ListBox
        private void ActualizarLista(ListBox lst, List<int> datos)
        {
            lst.Items.Clear();
            lst.BeginUpdate();
            for (int i = 0; i < datos.Count && i < 2000; i++) lst.Items.Add(datos[i]);
            lst.EndUpdate();
        }
    }
}