
namespace ProyectoFinal.Forms
{
    partial class FrmOrdenamiento
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpGenerar;
        private System.Windows.Forms.GroupBox grpInsertion;
        private System.Windows.Forms.GroupBox grpQuick;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ListBox lstOriginal;

        private System.Windows.Forms.ListBox lstInsertion;
        private System.Windows.Forms.Button btnInsertAsc;
        private System.Windows.Forms.Button btnInsertDesc;
        private System.Windows.Forms.Label lblResInsertion;

        private System.Windows.Forms.ListBox lstQuick;
        private System.Windows.Forms.Button btnQuickAsc;
        private System.Windows.Forms.Button btnQuickDesc;
        private System.Windows.Forms.Label lblResQuick;
        private System.Windows.Forms.Label lblEtiquetaCant;

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
            lstOriginal = new ListBox();
            grpInsertion = new GroupBox();
            lstInsertion = new ListBox();
            btnInsertAsc = new Button();
            btnInsertDesc = new Button();
            lblResInsertion = new Label();
            grpQuick = new GroupBox();
            lstQuick = new ListBox();
            btnQuickAsc = new Button();
            btnQuickDesc = new Button();
            lblResQuick = new Label();
            grpGenerar.SuspendLayout();
            grpInsertion.SuspendLayout();
            grpQuick.SuspendLayout();
            SuspendLayout();
            // 
            // grpGenerar
            // 
            grpGenerar.Controls.Add(lblEtiquetaCant);
            grpGenerar.Controls.Add(txtCantidad);
            grpGenerar.Controls.Add(btnGenerar);
            grpGenerar.Controls.Add(lstOriginal);
            grpGenerar.Location = new Point(14, 16);
            grpGenerar.Margin = new Padding(3, 4, 3, 4);
            grpGenerar.Name = "grpGenerar";
            grpGenerar.Padding = new Padding(3, 4, 3, 4);
            grpGenerar.Size = new Size(286, 667);
            grpGenerar.TabIndex = 0;
            grpGenerar.TabStop = false;
            grpGenerar.Text = "1. Datos Originales";
            // 
            // lblEtiquetaCant
            // 
            lblEtiquetaCant.Location = new Point(11, 33);
            lblEtiquetaCant.Name = "lblEtiquetaCant";
            lblEtiquetaCant.Size = new Size(74, 31);
            lblEtiquetaCant.TabIndex = 0;
            lblEtiquetaCant.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(91, 29);
            txtCantidad.Margin = new Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(145, 27);
            txtCantidad.TabIndex = 1;
            txtCantidad.TextChanged += txtCantidad_TextChanged;
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
            // lstOriginal
            // 
            lstOriginal.Location = new Point(11, 133);
            lstOriginal.Margin = new Padding(3, 4, 3, 4);
            lstOriginal.Name = "lstOriginal";
            lstOriginal.Size = new Size(262, 504);
            lstOriginal.TabIndex = 3;
            // 
            // grpInsertion
            // 
            grpInsertion.Controls.Add(lstInsertion);
            grpInsertion.Controls.Add(btnInsertAsc);
            grpInsertion.Controls.Add(btnInsertDesc);
            grpInsertion.Controls.Add(lblResInsertion);
            grpInsertion.Location = new Point(309, 16);
            grpInsertion.Margin = new Padding(3, 4, 3, 4);
            grpInsertion.Name = "grpInsertion";
            grpInsertion.Padding = new Padding(3, 4, 3, 4);
            grpInsertion.Size = new Size(286, 667);
            grpInsertion.TabIndex = 1;
            grpInsertion.TabStop = false;
            grpInsertion.Text = "2. Insertion Sort";
            // 
            // lstInsertion
            // 
            lstInsertion.Location = new Point(11, 33);
            lstInsertion.Margin = new Padding(3, 4, 3, 4);
            lstInsertion.Name = "lstInsertion";
            lstInsertion.Size = new Size(262, 384);
            lstInsertion.TabIndex = 0;
            // 
            // btnInsertAsc
            // 
            btnInsertAsc.Location = new Point(11, 453);
            btnInsertAsc.Margin = new Padding(3, 4, 3, 4);
            btnInsertAsc.Name = "btnInsertAsc";
            btnInsertAsc.Size = new Size(263, 40);
            btnInsertAsc.TabIndex = 1;
            btnInsertAsc.Text = "Ordenar Ascendente";
            btnInsertAsc.Click += BtnInsertAsc_Click;
            // 
            // btnInsertDesc
            // 
            btnInsertDesc.Location = new Point(11, 507);
            btnInsertDesc.Margin = new Padding(3, 4, 3, 4);
            btnInsertDesc.Name = "btnInsertDesc";
            btnInsertDesc.Size = new Size(263, 40);
            btnInsertDesc.TabIndex = 2;
            btnInsertDesc.Text = "Ordenar Descendente";
            btnInsertDesc.Click += BtnInsertDesc_Click;
            // 
            // lblResInsertion
            // 
            lblResInsertion.AutoSize = true;
            lblResInsertion.Location = new Point(11, 560);
            lblResInsertion.Name = "lblResInsertion";
            lblResInsertion.Size = new Size(88, 40);
            lblResInsertion.TabIndex = 3;
            lblResInsertion.Text = "Tiempo: --\nMemoria: --";
            // 
            // grpQuick
            // 
            grpQuick.Controls.Add(lstQuick);
            grpQuick.Controls.Add(btnQuickAsc);
            grpQuick.Controls.Add(btnQuickDesc);
            grpQuick.Controls.Add(lblResQuick);
            grpQuick.Location = new Point(606, 16);
            grpQuick.Margin = new Padding(3, 4, 3, 4);
            grpQuick.Name = "grpQuick";
            grpQuick.Padding = new Padding(3, 4, 3, 4);
            grpQuick.Size = new Size(286, 667);
            grpQuick.TabIndex = 2;
            grpQuick.TabStop = false;
            grpQuick.Text = "3. Quick Sort";
            // 
            // lstQuick
            // 
            lstQuick.Location = new Point(11, 33);
            lstQuick.Margin = new Padding(3, 4, 3, 4);
            lstQuick.Name = "lstQuick";
            lstQuick.Size = new Size(262, 384);
            lstQuick.TabIndex = 0;
            // 
            // btnQuickAsc
            // 
            btnQuickAsc.Location = new Point(11, 453);
            btnQuickAsc.Margin = new Padding(3, 4, 3, 4);
            btnQuickAsc.Name = "btnQuickAsc";
            btnQuickAsc.Size = new Size(263, 40);
            btnQuickAsc.TabIndex = 1;
            btnQuickAsc.Text = "Ordenar Ascendente";
            btnQuickAsc.Click += BtnQuickAsc_Click;
            // 
            // btnQuickDesc
            // 
            btnQuickDesc.Location = new Point(11, 507);
            btnQuickDesc.Margin = new Padding(3, 4, 3, 4);
            btnQuickDesc.Name = "btnQuickDesc";
            btnQuickDesc.Size = new Size(263, 40);
            btnQuickDesc.TabIndex = 2;
            btnQuickDesc.Text = "Ordenar Descendente";
            btnQuickDesc.Click += BtnQuickDesc_Click;
            // 
            // lblResQuick
            // 
            lblResQuick.AutoSize = true;
            lblResQuick.Location = new Point(11, 560);
            lblResQuick.Name = "lblResQuick";
            lblResQuick.Size = new Size(88, 40);
            lblResQuick.TabIndex = 3;
            lblResQuick.Text = "Tiempo: --\nMemoria: --";
            // 
            // FrmOrdenamiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 707);
            Controls.Add(grpGenerar);
            Controls.Add(grpInsertion);
            Controls.Add(grpQuick);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmOrdenamiento";
            Text = "Algoritmos de ordenamiento";
            grpGenerar.ResumeLayout(false);
            grpGenerar.PerformLayout();
            grpInsertion.ResumeLayout(false);
            grpInsertion.PerformLayout();
            grpQuick.ResumeLayout(false);
            grpQuick.PerformLayout();
            ResumeLayout(false);
        }


    }
}