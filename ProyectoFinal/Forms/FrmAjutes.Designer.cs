namespace ProyectoFinal.Forms
{
    partial class FrmAjustes
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.GroupBox grpApariencia;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpApariencia = new System.Windows.Forms.GroupBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();

            this.grpApariencia.SuspendLayout();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(30, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(111, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Ajustes";

            // grpApariencia
            this.grpApariencia.Controls.Add(this.lblInstruccion);
            this.grpApariencia.Controls.Add(this.btnColor);
            this.grpApariencia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpApariencia.Location = new System.Drawing.Point(37, 85);
            this.grpApariencia.Name = "grpApariencia";
            this.grpApariencia.Size = new System.Drawing.Size(400, 200);
            this.grpApariencia.TabIndex = 1;
            this.grpApariencia.TabStop = false;
            this.grpApariencia.Text = "Apariencia General";

            // lblInstruccion
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.Location = new System.Drawing.Point(20, 40);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(300, 40);
            this.lblInstruccion.TabIndex = 0;
            this.lblInstruccion.Text = "Seleccione el color de fondo para las ventanas \nde la aplicación:";

            // btnColor
            this.btnColor.BackColor = System.Drawing.Color.LightGray;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Location = new System.Drawing.Point(24, 100);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(200, 40);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "Cambiar Color de Fondo";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.BtnColor_Click);

            // FrmAjustes
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.grpApariencia);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmAjustes";
            this.Text = "Ajustes";
            this.grpApariencia.ResumeLayout(false);
            this.grpApariencia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}