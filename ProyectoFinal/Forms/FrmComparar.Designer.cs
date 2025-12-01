namespace ProyectoFinal.Forms
{
    partial class FrmComparar
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpControles;
        private System.Windows.Forms.Panel pnlGrafica; // Contenedor para la gráfica
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbOrdenamiento;
        private System.Windows.Forms.RadioButton rbBusqueda;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Label lblBigO;

        // Control de ScottPlot
        private ScottPlot.WinForms.FormsPlot formsPlot1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpControles = new System.Windows.Forms.GroupBox();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbOrdenamiento = new System.Windows.Forms.RadioButton();
            this.rbBusqueda = new System.Windows.Forms.RadioButton();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.lblBigO = new System.Windows.Forms.Label();
            this.pnlGrafica = new System.Windows.Forms.Panel();
            this.formsPlot1 = new ScottPlot.WinForms.FormsPlot();

            this.grpControles.SuspendLayout();
            this.pnlGrafica.SuspendLayout();
            this.SuspendLayout();

            // 
            // grpControles
            // 
            this.grpControles.Controls.Add(this.lblBigO);
            this.grpControles.Controls.Add(this.rbTodos);
            this.grpControles.Controls.Add(this.rbOrdenamiento);
            this.grpControles.Controls.Add(this.rbBusqueda);
            this.grpControles.Controls.Add(this.lblPregunta);
            this.grpControles.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpControles.Location = new System.Drawing.Point(0, 0);
            this.grpControles.Name = "grpControles";
            this.grpControles.Size = new System.Drawing.Size(200, 530);
            this.grpControles.TabIndex = 0;
            this.grpControles.TabStop = false;
            this.grpControles.Text = "Controles";

            // lblPregunta
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPregunta.Location = new System.Drawing.Point(10, 30);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(107, 15);
            this.lblPregunta.TabIndex = 0;
            this.lblPregunta.Text = "¿Qué comparar?";

            // RadioButtons
            this.rbBusqueda.AutoSize = true;
            this.rbBusqueda.Location = new System.Drawing.Point(15, 60);
            this.rbBusqueda.Name = "rbBusqueda";
            this.rbBusqueda.Size = new System.Drawing.Size(76, 19);
            this.rbBusqueda.TabIndex = 1;
            this.rbBusqueda.Text = "Búsqueda";
            this.rbBusqueda.CheckedChanged += new System.EventHandler(this.Filtros_CheckedChanged);

            this.rbOrdenamiento.AutoSize = true;
            this.rbOrdenamiento.Location = new System.Drawing.Point(15, 90);
            this.rbOrdenamiento.Name = "rbOrdenamiento";
            this.rbOrdenamiento.Size = new System.Drawing.Size(103, 19);
            this.rbOrdenamiento.TabIndex = 2;
            this.rbOrdenamiento.Text = "Ordenamiento";
            this.rbOrdenamiento.CheckedChanged += new System.EventHandler(this.Filtros_CheckedChanged);

            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Location = new System.Drawing.Point(15, 120);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(56, 19);
            this.rbTodos.TabIndex = 3;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.CheckedChanged += new System.EventHandler(this.Filtros_CheckedChanged);

            // lblBigO
            this.lblBigO.Location = new System.Drawing.Point(12, 160);
            this.lblBigO.Name = "lblBigO";
            this.lblBigO.Size = new System.Drawing.Size(182, 361);
            this.lblBigO.TabIndex = 4;
            this.lblBigO.Text = "Seleccione una opción para ver el análisis.";

            // 
            // pnlGrafica (Contenedor derecho)
            // 
            this.pnlGrafica.Controls.Add(this.formsPlot1);
            this.pnlGrafica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrafica.Location = new System.Drawing.Point(200, 0);
            this.pnlGrafica.Name = "pnlGrafica";
            this.pnlGrafica.Padding = new System.Windows.Forms.Padding(10);
            this.pnlGrafica.Size = new System.Drawing.Size(600, 530);
            this.pnlGrafica.TabIndex = 1;

            // 
            // formsPlot1 (El control de ScottPlot)
            // 
            this.formsPlot1.DisplayScale = 1F;
            this.formsPlot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlot1.Location = new System.Drawing.Point(10, 10);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(580, 510);
            this.formsPlot1.TabIndex = 0;

            // FrmComparar
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.pnlGrafica);
            this.Controls.Add(this.grpControles);
            this.Name = "FrmComparar";
            this.Text = "Comparación de Resultados";
            this.grpControles.ResumeLayout(false);
            this.grpControles.PerformLayout();
            this.pnlGrafica.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}