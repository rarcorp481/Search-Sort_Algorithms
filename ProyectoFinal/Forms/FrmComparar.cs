using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoFinal.Forms
{
    public partial class FrmComparar : Form
    {
        public FrmComparar()
        {
            InitializeComponent();
            this.BackColor = DatosGlobales.ColorFondo;
            rbTodos.Checked = true;
        }

        private void Filtros_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarGrafica();
        }

        public void ActualizarGrafica()
        {
            chartResultados.Series.Clear();

            var datos = DatosGlobales.Resultados;
            if (datos.Count == 0)
            {
                lblBigO.Text = "No hay datos registrados.\nEjecuta los algoritmos primero.";
                return;
            }

            // Filtrado
            if (rbBusqueda.Checked)
            {
                datos = datos.Where(x => x.Tipo == "Busqueda").ToList();
                lblBigO.Text = "Análisis:\n\n- Lineal: O(n)\n- Binaria: O(log n)";
            }
            else if (rbOrdenamiento.Checked)
            {
                datos = datos.Where(x => x.Tipo == "Ordenamiento").ToList();
                lblBigO.Text = "Análisis:\n\n- Insertion: O(n^2)\n- QuickSort: O(n log n)";
            }
            else
            {
                lblBigO.Text = "Mostrando Todos.\nCompare la escala de tiempo.";
            }

            if (datos.Count == 0) return;

            // Generación de Series
            var grupos = datos.GroupBy(x => x.Nombre);

            foreach (var grupo in grupos)
            {
                Series serie = new Series(grupo.Key);
                serie.ChartType = SeriesChartType.Line;
                serie.BorderWidth = 3;
                serie.MarkerStyle = MarkerStyle.Circle;
                serie.MarkerSize = 7;

                foreach (var punto in grupo.OrderBy(x => x.CantidadElementos))
                {
                    // Graficamos Segundos vs Cantidad
                    serie.Points.AddXY(punto.CantidadElementos, punto.TiempoSegundos);
                }

                chartResultados.Series.Add(serie);
            }
        }
    }
}