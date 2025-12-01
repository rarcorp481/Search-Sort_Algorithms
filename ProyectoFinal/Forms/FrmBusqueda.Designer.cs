
namespace ProyectoFinal.Forms
{
    partial class FrmBusqueda
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpGenerar;
        private System.Windows.Forms.GroupBox grpLineal;
        private System.Windows.Forms.GroupBox grpBinaria;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ListBox lstNumeros;
        private System.Windows.Forms.TextBox txtBuscarLineal;
        private System.Windows.Forms.Button btnLineal;
        private System.Windows.Forms.Label lblResLineal;
        private System.Windows.Forms.Button btnBinaria;
        private System.Windows.Forms.Label lblResBinaria;
        private System.Windows.Forms.Label lblEtiquetaCant;
        private System.Windows.Forms.Label lblBuscarLineal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            grpGenerar = new GroupBox();
            lblEtiquetaCant = new Label();
            txtCantidad = new TextBox();
            btnGenerar = new Button();
            lstNumeros = new ListBox();
            grpLineal = new GroupBox();
            lblBuscarLineal = new Label();
            txtBuscarLineal = new TextBox();
            btnLineal = new Button();
            lblResLineal = new Label();
            grpBinaria = new GroupBox();
            lblBuscarBinaria = new Label();
            txtBuscarBinaria = new TextBox();
            btnBinaria = new Button();
            lblResBinaria = new Label();
            grpGenerar.SuspendLayout();
            grpLineal.SuspendLayout();
            grpBinaria.SuspendLayout();
            SuspendLayout();
            // 
            // grpGenerar
            // 
            grpGenerar.Controls.Add(lblEtiquetaCant);
            grpGenerar.Controls.Add(txtCantidad);
            grpGenerar.Controls.Add(btnGenerar);
            grpGenerar.Controls.Add(lstNumeros);
            grpGenerar.Location = new Point(14, 16);
            grpGenerar.Margin = new Padding(3, 4, 3, 4);
            grpGenerar.Name = "grpGenerar";
            grpGenerar.Padding = new Padding(3, 4, 3, 4);
            grpGenerar.Size = new Size(286, 667);
            grpGenerar.TabIndex = 0;
            grpGenerar.TabStop = false;
            grpGenerar.Text = "1. Generación de Datos";
            // 
            // lblEtiquetaCant
            // 
            lblEtiquetaCant.AutoSize = true;
            lblEtiquetaCant.Location = new Point(11, 33);
            lblEtiquetaCant.Name = "lblEtiquetaCant";
            lblEtiquetaCant.Size = new Size(72, 20);
            lblEtiquetaCant.TabIndex = 0;
            lblEtiquetaCant.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(91, 29);
            txtCantidad.Margin = new Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(114, 27);
            txtCantidad.TabIndex = 1;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(11, 80);
            btnGenerar.Margin = new Padding(3, 4, 3, 4);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(263, 40);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Generar";
            btnGenerar.Click += BtnGenerar_Click;
            // 
            // lstNumeros
            // 
            lstNumeros.Location = new Point(11, 133);
            lstNumeros.Margin = new Padding(3, 4, 3, 4);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(262, 504);
            lstNumeros.TabIndex = 3;
            // 
            // grpLineal
            // 
            grpLineal.Controls.Add(lblBuscarLineal);
            grpLineal.Controls.Add(txtBuscarLineal);
            grpLineal.Controls.Add(btnLineal);
            grpLineal.Controls.Add(lblResLineal);
            grpLineal.Location = new Point(309, 16);
            grpLineal.Margin = new Padding(3, 4, 3, 4);
            grpLineal.Name = "grpLineal";
            grpLineal.Padding = new Padding(3, 4, 3, 4);
            grpLineal.Size = new Size(286, 667);
            grpLineal.TabIndex = 1;
            grpLineal.TabStop = false;
            grpLineal.Text = "2. Búsqueda Lineal (Secuencial)";
            // 
            // lblBuscarLineal
            // 
            lblBuscarLineal.AutoSize = true;
            lblBuscarLineal.Location = new Point(11, 33);
            lblBuscarLineal.Name = "lblBuscarLineal";
            lblBuscarLineal.Size = new Size(113, 20);
            lblBuscarLineal.TabIndex = 0;
            lblBuscarLineal.Text = "Buscar Número:";
            // 
            // txtBuscarLineal
            // 
            txtBuscarLineal.Location = new Point(11, 67);
            txtBuscarLineal.Margin = new Padding(3, 4, 3, 4);
            txtBuscarLineal.Name = "txtBuscarLineal";
            txtBuscarLineal.Size = new Size(262, 27);
            txtBuscarLineal.TabIndex = 1;
            // 
            // btnLineal
            // 
            btnLineal.Location = new Point(11, 120);
            btnLineal.Margin = new Padding(3, 4, 3, 4);
            btnLineal.Name = "btnLineal";
            btnLineal.Size = new Size(263, 53);
            btnLineal.TabIndex = 2;
            btnLineal.Text = "Buscar (Lineal)";
            btnLineal.Click += BtnLineal_Click;
            // 
            // lblResLineal
            // 
            lblResLineal.AutoSize = true;
            lblResLineal.Location = new Point(11, 200);
            lblResLineal.Name = "lblResLineal";
            lblResLineal.Size = new Size(88, 40);
            lblResLineal.TabIndex = 3;
            lblResLineal.Text = "Resultados:\nEsperando...";
            // 
            // grpBinaria
            // 
            grpBinaria.Controls.Add(lblBuscarBinaria);
            grpBinaria.Controls.Add(txtBuscarBinaria);
            grpBinaria.Controls.Add(btnBinaria);
            grpBinaria.Controls.Add(lblResBinaria);
            grpBinaria.Location = new Point(606, 16);
            grpBinaria.Margin = new Padding(3, 4, 3, 4);
            grpBinaria.Name = "grpBinaria";
            grpBinaria.Padding = new Padding(3, 4, 3, 4);
            grpBinaria.Size = new Size(287, 667);
            grpBinaria.TabIndex = 2;
            grpBinaria.TabStop = false;
            grpBinaria.Text = "3. Búsqueda Binaria";
            // 
            // lblBuscarBinaria
            // 
            lblBuscarBinaria.AutoSize = true;
            lblBuscarBinaria.Location = new Point(12, 36);
            lblBuscarBinaria.Name = "lblBuscarBinaria";
            lblBuscarBinaria.Size = new Size(113, 20);
            lblBuscarBinaria.TabIndex = 4;
            lblBuscarBinaria.Text = "Buscar Número:";
            // 
            // txtBuscarBinaria
            // 
            txtBuscarBinaria.Location = new Point(12, 67);
            txtBuscarBinaria.Margin = new Padding(3, 4, 3, 4);
            txtBuscarBinaria.Name = "txtBuscarBinaria";
            txtBuscarBinaria.Size = new Size(262, 27);
            txtBuscarBinaria.TabIndex = 2;
            // 
            // btnBinaria
            // 
            btnBinaria.Location = new Point(11, 120);
            btnBinaria.Margin = new Padding(3, 4, 3, 4);
            btnBinaria.Name = "btnBinaria";
            btnBinaria.Size = new Size(263, 53);
            btnBinaria.TabIndex = 0;
            btnBinaria.Text = "Buscar (Binaria)";
            btnBinaria.Click += BtnBinaria_Click;
            // 
            // lblResBinaria
            // 
            lblResBinaria.AutoSize = true;
            lblResBinaria.Location = new Point(11, 200);
            lblResBinaria.Name = "lblResBinaria";
            lblResBinaria.Size = new Size(88, 40);
            lblResBinaria.TabIndex = 1;
            lblResBinaria.Text = "Resultados:\nEsperando...";
            // 
            // FrmBusqueda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 707);
            Controls.Add(grpGenerar);
            Controls.Add(grpLineal);
            Controls.Add(grpBinaria);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmBusqueda";
            Text = "Algoritmos de búsqueda";
            Load += FrmBusqueda_Load;
            grpGenerar.ResumeLayout(false);
            grpGenerar.PerformLayout();
            grpLineal.ResumeLayout(false);
            grpLineal.PerformLayout();
            grpBinaria.ResumeLayout(false);
            grpBinaria.PerformLayout();
            ResumeLayout(false);
        }



        private Label lblBuscarBinaria;
        private TextBox txtBuscarBinaria;
    }
}