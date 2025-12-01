namespace ProyectoFinal.Forms
{
    partial class FrmComparar
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlGrafica;
        private System.Windows.Forms.TableLayoutPanel tblLayout;
        private ScottPlot.WinForms.FormsPlot plotLineal;
        private ScottPlot.WinForms.FormsPlot plotBinaria;
        private ScottPlot.WinForms.FormsPlot plotInsertion;
        private ScottPlot.WinForms.FormsPlot plotQuick;
        private System.Windows.Forms.GroupBox grpLeyenda;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnBenchmark; // Botón Nuevo

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlGrafica = new Panel();
            tblLayout = new TableLayoutPanel();
            plotLineal = new ScottPlot.WinForms.FormsPlot();
            plotBinaria = new ScottPlot.WinForms.FormsPlot();
            plotInsertion = new ScottPlot.WinForms.FormsPlot();
            plotQuick = new ScottPlot.WinForms.FormsPlot();
            grpLeyenda = new GroupBox();
            btnBenchmark = new Button();
            lblInfo = new Label();
            pnlGrafica.SuspendLayout();
            tblLayout.SuspendLayout();
            grpLeyenda.SuspendLayout();
            SuspendLayout();
            // 
            // pnlGrafica
            // 
            pnlGrafica.Controls.Add(tblLayout);
            pnlGrafica.Dock = DockStyle.Fill;
            pnlGrafica.Location = new Point(229, 0);
            pnlGrafica.Margin = new Padding(3, 4, 3, 4);
            pnlGrafica.Name = "pnlGrafica";
            pnlGrafica.Padding = new Padding(11, 13, 11, 13);
            pnlGrafica.Size = new Size(896, 748);
            pnlGrafica.TabIndex = 0;
            // 
            // tblLayout
            // 
            tblLayout.ColumnCount = 2;
            tblLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblLayout.Controls.Add(plotLineal, 0, 0);
            tblLayout.Controls.Add(plotBinaria, 1, 0);
            tblLayout.Controls.Add(plotInsertion, 0, 1);
            tblLayout.Controls.Add(plotQuick, 1, 1);
            tblLayout.Dock = DockStyle.Fill;
            tblLayout.Location = new Point(11, 13);
            tblLayout.Margin = new Padding(3, 4, 3, 4);
            tblLayout.Name = "tblLayout";
            tblLayout.RowCount = 2;
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblLayout.Size = new Size(874, 722);
            tblLayout.TabIndex = 0;
            // 
            // plotLineal
            // 
            plotLineal.DisplayScale = 1.25F;
            plotLineal.Dock = DockStyle.Fill;
            plotLineal.Location = new Point(3, 4);
            plotLineal.Margin = new Padding(3, 4, 3, 4);
            plotLineal.Name = "plotLineal";
            plotLineal.Size = new Size(431, 353);
            plotLineal.TabIndex = 0;
            // 
            // plotBinaria
            // 
            plotBinaria.DisplayScale = 1.25F;
            plotBinaria.Dock = DockStyle.Fill;
            plotBinaria.Location = new Point(440, 4);
            plotBinaria.Margin = new Padding(3, 4, 3, 4);
            plotBinaria.Name = "plotBinaria";
            plotBinaria.Size = new Size(431, 353);
            plotBinaria.TabIndex = 1;
            // 
            // plotInsertion
            // 
            plotInsertion.DisplayScale = 1.25F;
            plotInsertion.Dock = DockStyle.Fill;
            plotInsertion.Location = new Point(3, 365);
            plotInsertion.Margin = new Padding(3, 4, 3, 4);
            plotInsertion.Name = "plotInsertion";
            plotInsertion.Size = new Size(431, 353);
            plotInsertion.TabIndex = 2;
            // 
            // plotQuick
            // 
            plotQuick.DisplayScale = 1.25F;
            plotQuick.Dock = DockStyle.Fill;
            plotQuick.Location = new Point(440, 365);
            plotQuick.Margin = new Padding(3, 4, 3, 4);
            plotQuick.Name = "plotQuick";
            plotQuick.Size = new Size(431, 353);
            plotQuick.TabIndex = 3;
            // 
            // grpLeyenda
            // 
            grpLeyenda.Controls.Add(btnBenchmark);
            grpLeyenda.Controls.Add(lblInfo);
            grpLeyenda.Dock = DockStyle.Left;
            grpLeyenda.Location = new Point(0, 0);
            grpLeyenda.Margin = new Padding(3, 4, 3, 4);
            grpLeyenda.Name = "grpLeyenda";
            grpLeyenda.Padding = new Padding(3, 4, 3, 4);
            grpLeyenda.Size = new Size(229, 748);
            grpLeyenda.TabIndex = 1;
            grpLeyenda.TabStop = false;
            grpLeyenda.Text = "Controles";
            // 
            // btnBenchmark
            // 
            btnBenchmark.BackColor = Color.SteelBlue;
            btnBenchmark.FlatStyle = FlatStyle.Flat;
            btnBenchmark.ForeColor = Color.White;
            btnBenchmark.Location = new Point(14, 40);
            btnBenchmark.Margin = new Padding(3, 4, 3, 4);
            btnBenchmark.Name = "btnBenchmark";
            btnBenchmark.Size = new Size(201, 67);
            btnBenchmark.TabIndex = 0;
            btnBenchmark.Text = "Ejecutar Benchmark";
            btnBenchmark.UseVisualStyleBackColor = false;
            btnBenchmark.Click += BtnBenchmark_Click;
            // 
            // lblInfo
            // 
            lblInfo.Location = new Point(11, 133);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(206, 533);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Presiona 'Ejecutar Benchmark\r\n' para generar las curvas de rendimiento (Pasos vs Cantidad).";
            // 
            // FrmComparar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 748);
            Controls.Add(pnlGrafica);
            Controls.Add(grpLeyenda);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmComparar";
            Text = "Comparación de Algoritmos (Notación Big O)";
            pnlGrafica.ResumeLayout(false);
            tblLayout.ResumeLayout(false);
            grpLeyenda.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}