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

        // INSERTION SORT
        private void BtnInsertAsc_Click(object sender, EventArgs e) => EjecutarInsertion(true);
        private void BtnInsertDesc_Click(object sender, EventArgs e) => EjecutarInsertion(false);

        private async void EjecutarInsertion(bool asc)
        {
            if (listaOriginal.Count == 0) return;
            if (listaOriginal.Count > 10000 && MessageBox.Show("Esto tomará millones de pasos. ¿Seguro?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.No) return;

            btnInsertAsc.Enabled = false; btnInsertDesc.Enabled = false;
            lblResInsertion.Text = "Contando pasos...";

            var resultado = await Task.Run(() =>
            {
                long pasos = 0;
                long m1 = GC.GetAllocatedBytesForCurrentThread();
                Stopwatch sw = Stopwatch.StartNew();

                List<int> copia = new List<int>(listaOriginal);

                for (int i = 1; i < copia.Count; i++)
                {
                    int key = copia[i];
                    int j = i - 1;

                    // El while hace las comparaciones
                    while (j >= 0)
                    {
                        pasos++; // PASO DE COMPARACIÓN
                        if (asc ? copia[j] > key : copia[j] < key)
                        {
                            copia[j + 1] = copia[j];
                            j--;
                        }
                        else break;
                    }
                    copia[j + 1] = key;
                }

                sw.Stop();
                long m2 = GC.GetAllocatedBytesForCurrentThread();

                return new { Lista = copia, Tiempo = sw.Elapsed.TotalSeconds, Memoria = m2 - m1, Pasos = pasos };
            });

            ActualizarLista(lstInsertion, resultado.Lista);
            lblResInsertion.Text = $"Pasos: {resultado.Pasos:N0}\nMemoria: {resultado.Memoria:N0} bytes";

            DatosGlobales.Resultados.Add(new ResultadoAlgoritmo
            {
                Nombre = "Insertion Sort",
                CantidadElementos = listaOriginal.Count,
                TiempoSegundos = resultado.Tiempo,
                Pasos = resultado.Pasos, // Guardamos Pasos
                Tipo = "Ordenamiento"
            });

            btnInsertAsc.Enabled = true; btnInsertDesc.Enabled = true;
        }

        // QUICK SORT
        private void BtnQuickAsc_Click(object sender, EventArgs e) => EjecutarQuick(true);
        private void BtnQuickDesc_Click(object sender, EventArgs e) => EjecutarQuick(false);

        private async void EjecutarQuick(bool asc)
        {
            if (listaOriginal.Count == 0) return;

            btnQuickAsc.Enabled = false; btnQuickDesc.Enabled = false;
            lblResQuick.Text = "Contando pasos...";

            var resultado = await Task.Run(() =>
            {
                long pasosTotales = 0;
                long m1 = GC.GetAllocatedBytesForCurrentThread();
                Stopwatch sw = Stopwatch.StartNew();

                List<int> copia = new List<int>(listaOriginal);
                QuickSortRec(copia, 0, copia.Count - 1, asc, ref pasosTotales);

                sw.Stop();
                long m2 = GC.GetAllocatedBytesForCurrentThread();

                return new { Lista = copia, Tiempo = sw.Elapsed.TotalSeconds, Memoria = m2 - m1, Pasos = pasosTotales };
            });

            ActualizarLista(lstQuick, resultado.Lista);
            lblResQuick.Text = $"Pasos: {resultado.Pasos:N0}\nMemoria: {resultado.Memoria:N0} bytes";

            DatosGlobales.Resultados.Add(new ResultadoAlgoritmo
            {
                Nombre = "Quick Sort",
                CantidadElementos = listaOriginal.Count,
                TiempoSegundos = resultado.Tiempo,
                Pasos = resultado.Pasos, // Guardamos Pasos
                Tipo = "Ordenamiento"
            });

            btnQuickAsc.Enabled = true; btnQuickDesc.Enabled = true;
        }

        private void QuickSortRec(List<int> arr, int low, int high, bool asc, ref long pasos)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high, asc, ref pasos);
                QuickSortRec(arr, low, pi - 1, asc, ref pasos);
                QuickSortRec(arr, pi + 1, high, asc, ref pasos);
            }
        }

        private int Partition(List<int> arr, int low, int high, bool asc, ref long pasos)
        {
            int pivot = arr[high];
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                pasos++; // PASO DE COMPARACIÓN
                if (asc ? arr[j] < pivot : arr[j] > pivot)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }
            (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
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
            // Enable Generate only for valid positive integers
            if (int.TryParse(txtCantidad.Text.Trim(), out int n) && n > 0)
                btnGenerar.Enabled = true;
            else
                btnGenerar.Enabled = false;
        }
    }
}