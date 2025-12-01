namespace ProyectoFinal.Forms
{
    partial class FrmComparar
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpControles;
        private System.Windows.Forms.Panel pnlGrafica;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbOrdenamiento;
        private System.Windows.Forms.RadioButton rbBusqueda;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResultados;
        private System.Windows.Forms.Label lblBigO;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();

            this.grpControles = new System.Windows.Forms.GroupBox();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbOrdenamiento = new System.Windows.Forms.RadioButton();
            this.rbBusqueda = new System.Windows.Forms.RadioButton();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.pnlGrafica = new System.Windows.Forms.Panel();
            this.chartResultados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblBigO = new System.Windows.Forms.Label();

            this.grpControles.SuspendLayout();
            this.pnlGrafica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResultados)).BeginInit();
            this.SuspendLayout();

            // Configuración Controles
            this.grpControles.Location = new System.Drawing.Point(12, 12);
            this.grpControles.Size = new System.Drawing.Size(200, 500);
            this.grpControles.Controls.Add(this.lblBigO);
            this.grpControles.Controls.Add(this.rbTodos);
            this.grpControles.Controls.Add(this.rbOrdenamiento);
            this.grpControles.Controls.Add(this.rbBusqueda);
            this.grpControles.Controls.Add(this.lblPregunta);

            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(10, 20);
            this.lblPregunta.Text = "¿Qué comparar?";
            this.lblPregunta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.rbBusqueda.AutoSize = true;
            this.rbBusqueda.Location = new System.Drawing.Point(15, 60);
            this.rbBusqueda.Text = "Búsqueda";
            this.rbBusqueda.CheckedChanged += new System.EventHandler(this.Filtros_CheckedChanged);

            this.rbOrdenamiento.AutoSize = true;
            this.rbOrdenamiento.Location = new System.Drawing.Point(15, 90);
            this.rbOrdenamiento.Text = "Ordenamiento";
            this.rbOrdenamiento.CheckedChanged += new System.EventHandler(this.Filtros_CheckedChanged);

            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(15, 120);
            this.rbTodos.Text = "Todos";
            this.rbTodos.CheckedChanged += new System.EventHandler(this.Filtros_CheckedChanged);

            this.lblBigO.Location = new System.Drawing.Point(10, 200);
            this.lblBigO.Size = new System.Drawing.Size(180, 200);
            this.lblBigO.Text = "Seleccione una opción.";

            // Configuración Gráfica
            this.pnlGrafica.Location = new System.Drawing.Point(220, 12);
            this.pnlGrafica.Size = new System.Drawing.Size(560, 500);
            this.pnlGrafica.Controls.Add(this.chartResultados);

            chartArea1.Name = "ChartArea1";
            chartArea1.AxisX.Title = "Cantidad Elementos (N)";
            chartArea1.AxisY.Title = "Tiempo (Segundos)"; // Eje Y actualizado
            chartArea1.AxisY.LabelStyle.Format = "F5"; // Formato decimal en eje
            this.chartResultados.ChartAreas.Add(chartArea1);
            this.chartResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            this.chartResultados.Legends.Add(legend1);
            this.chartResultados.Name = "chartResultados";

            // FrmComparar
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.grpControles);
            this.Controls.Add(this.pnlGrafica);
            this.Name = "FrmComparar";
            this.Text = "Comparación de resultados";
            this.grpControles.ResumeLayout(false);
            this.grpControles.PerformLayout();
            this.pnlGrafica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResultados)).EndInit();
            this.ResumeLayout(false);
        }
    }
}