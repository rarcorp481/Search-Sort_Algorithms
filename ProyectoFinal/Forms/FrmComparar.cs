using System;
using System.Data;
using System.Linq;
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

            // Títulos Claros
            formsPlot1.Plot.Title("Complejidad Algorítmica (Pasos vs Elementos)");
            formsPlot1.Plot.Axes.Bottom.Label.Text = "Cantidad de Elementos (N)";
            formsPlot1.Plot.Axes.Left.Label.Text = "Operaciones Realizadas (Pasos)";

            rbTodos.Checked = true;
        }

        private void Filtros_CheckedChanged(object sender, EventArgs e) => ActualizarGrafica();

        public void ActualizarGrafica()
        {
            formsPlot1.Plot.Clear(); // Limpiamos la pizarra
            var datos = DatosGlobales.Resultados;

            if (datos == null || datos.Count == 0)
            {
                lblBigO.Text = "¡Sin datos!\nEjecuta pruebas con diferentes cantidades (ej: 100, 500, 1000) para ver la curva.";
                formsPlot1.Refresh();
                return;
            }

            // Filtrar
            if (rbBusqueda.Checked)
            {
                datos = datos.Where(x => x.Tipo == "Busqueda").ToList();
                lblBigO.Text = "Análisis de Pasos:\n\n" +
                               "● Lineal: ~N pasos (Línea recta).\n" +
                               "● Binaria: ~Log(N) pasos (Línea plana en el suelo).";
            }
            else if (rbOrdenamiento.Checked)
            {
                datos = datos.Where(x => x.Tipo == "Ordenamiento").ToList();
                lblBigO.Text = "Análisis de Pasos:\n\n" +
                               "● Insertion: ~N² pasos (Curva explosiva hacia arriba).\n" +
                               "● QuickSort: ~N*Log(N) pasos (Línea suave y baja).";
            }
            else
            {
                lblBigO.Text = "Comparativa Global:\nNota cómo los algoritmos ineficientes se disparan hacia arriba en pasos.";
            }

            if (datos.Count == 0)
            {
                formsPlot1.Refresh();
                return;
            }

            // Agrupar por algoritmo
            var grupos = datos.GroupBy(x => x.Nombre);

            foreach (var grupo in grupos)
            {
                // ORDENAR POR EJE X: Vital para que se dibuje una línea y no un garabato
                var puntosOrdenados = grupo.OrderBy(x => x.CantidadElementos).ToList();

                // Convertir a arrays para ScottPlot
                double[] xs = puntosOrdenados.Select(p => (double)p.CantidadElementos).ToArray();
                double[] ys = puntosOrdenados.Select(p => (double)p.Pasos).ToArray(); // <--- EJE Y AHORA SON PASOS

                // Dibujar Línea de Función (Scatter con línea conectada)
                var linea = formsPlot1.Plot.Add.Scatter(xs, ys);
                linea.LegendText = grupo.Key;
                linea.LineWidth = 3; // Línea gruesa para que se vea bien
                linea.MarkerSize = 10; // Puntos visibles
            }

            formsPlot1.Plot.ShowLegend();
            formsPlot1.Plot.Axes.AutoScale();
            formsPlot1.Refresh();
        }
    }
}