namespace ProyectoFinal.Forms
{
    partial class FrmHome
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Panel pnlDecoracion;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.pnlDecoracion = new System.Windows.Forms.Panel();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(40, 40);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(500, 47);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Bienvenido al Comparador";

            // lblDescripcion
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDescripcion.Location = new System.Drawing.Point(45, 110);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(650, 150);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Esta aplicación ha sido diseñada para analizar el rendimiento algorítmico.\n\n" +
                                     "Funcionalidades disponibles:\n" +
                                     "• Generación de datos aleatorios (0 - 500).\n" +
                                     "• Análisis de Búsqueda: Comparativa entre Lineal y Binaria.\n" +
                                     "• Análisis de Ordenamiento: Comparativa entre Insertion y Quick Sort.\n" +
                                     "• Gráficas de Rendimiento: Visualización de Time Complexity (Big O).\n\n" +
                                     "Seleccione una opción del menú lateral para comenzar.";

            // pnlDecoracion (Una línea decorativa simple)
            this.pnlDecoracion.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlDecoracion.Location = new System.Drawing.Point(45, 95);
            this.pnlDecoracion.Name = "pnlDecoracion";
            this.pnlDecoracion.Size = new System.Drawing.Size(100, 5);
            this.pnlDecoracion.TabIndex = 2;

            // FrmHome
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pnlDecoracion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmHome";
            this.Text = "Bienvenida";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}