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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            lblTitulo = new Label();
            lblDescripcion = new Label();
            pnlDecoracion = new Panel();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitulo.Location = new Point(46, 53);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(579, 60);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Bienvenido al Comparador";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 12F);
            lblDescripcion.Location = new Point(51, 147);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(649, 252);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = resources.GetString("lblDescripcion.Text");
            // 
            // pnlDecoracion
            // 
            pnlDecoracion.BackColor = Color.SteelBlue;
            pnlDecoracion.Location = new Point(51, 127);
            pnlDecoracion.Margin = new Padding(3, 4, 3, 4);
            pnlDecoracion.Name = "pnlDecoracion";
            pnlDecoracion.Size = new Size(114, 7);
            pnlDecoracion.TabIndex = 2;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 667);
            Controls.Add(pnlDecoracion);
            Controls.Add(lblDescripcion);
            Controls.Add(lblTitulo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmHome";
            Text = "Bienvenida";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}