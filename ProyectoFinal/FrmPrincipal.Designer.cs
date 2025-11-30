namespace ProyectoFinal
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            panelSideBar = new Panel();
            btnAjustes = new Button();
            FormIcons = new ImageList(components);
            btnSalir = new Button();
            btnComparar = new Button();
            btnOrdenamiento = new Button();
            btnBusqueda = new Button();
            btnHome = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelDock = new Panel();
            panelTitle = new Panel();
            panelSideBar.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelDock.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideBar
            // 
            panelSideBar.BackColor = Color.FromArgb(51, 51, 76);
            panelSideBar.Controls.Add(btnAjustes);
            panelSideBar.Controls.Add(btnSalir);
            panelSideBar.Controls.Add(btnComparar);
            panelSideBar.Controls.Add(btnOrdenamiento);
            panelSideBar.Controls.Add(btnBusqueda);
            panelSideBar.Controls.Add(btnHome);
            panelSideBar.Controls.Add(panelLogo);
            panelSideBar.Dock = DockStyle.Left;
            panelSideBar.Location = new Point(0, 0);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(303, 721);
            panelSideBar.TabIndex = 0;
            panelSideBar.Paint += panelSideBar_Paint;
            // 
            // btnAjustes
            // 
            btnAjustes.Dock = DockStyle.Bottom;
            btnAjustes.FlatAppearance.BorderSize = 0;
            btnAjustes.FlatStyle = FlatStyle.Flat;
            btnAjustes.Font = new Font("Segoe UI", 10F);
            btnAjustes.ForeColor = Color.AliceBlue;
            btnAjustes.ImageAlign = ContentAlignment.MiddleLeft;
            btnAjustes.ImageIndex = 1;
            btnAjustes.ImageList = FormIcons;
            btnAjustes.Location = new Point(0, 581);
            btnAjustes.Name = "btnAjustes";
            btnAjustes.Padding = new Padding(12, 0, 0, 0);
            btnAjustes.Size = new Size(303, 70);
            btnAjustes.TabIndex = 4;
            btnAjustes.Text = "  Ajustes";
            btnAjustes.TextAlign = ContentAlignment.MiddleLeft;
            btnAjustes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAjustes.UseVisualStyleBackColor = true;
            // 
            // FormIcons
            // 
            FormIcons.ColorDepth = ColorDepth.Depth32Bit;
            FormIcons.ImageStream = (ImageListStreamer)resources.GetObject("FormIcons.ImageStream");
            FormIcons.TransparentColor = Color.Transparent;
            FormIcons.Images.SetKeyName(0, "Compare32.png");
            FormIcons.Images.SetKeyName(1, "Settings32_Light.png");
            FormIcons.Images.SetKeyName(2, "Close32_Light.png");
            FormIcons.Images.SetKeyName(3, "Sort32_Light.png");
            FormIcons.Images.SetKeyName(4, "DatabaseSearch32_Light.png");
            FormIcons.Images.SetKeyName(5, "DarkMode32_light.png");
            FormIcons.Images.SetKeyName(6, "Home32_Light.png");
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Bottom;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10F);
            btnSalir.ForeColor = Color.AliceBlue;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.ImageIndex = 2;
            btnSalir.ImageList = FormIcons;
            btnSalir.Location = new Point(0, 651);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(12, 0, 0, 0);
            btnSalir.Size = new Size(303, 70);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "  Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnComparar
            // 
            btnComparar.Dock = DockStyle.Top;
            btnComparar.FlatAppearance.BorderSize = 0;
            btnComparar.FlatStyle = FlatStyle.Flat;
            btnComparar.Font = new Font("Segoe UI", 10F);
            btnComparar.ForeColor = Color.AliceBlue;
            btnComparar.ImageAlign = ContentAlignment.MiddleLeft;
            btnComparar.ImageIndex = 0;
            btnComparar.ImageList = FormIcons;
            btnComparar.Location = new Point(0, 295);
            btnComparar.Name = "btnComparar";
            btnComparar.Padding = new Padding(12, 0, 0, 0);
            btnComparar.Size = new Size(303, 70);
            btnComparar.TabIndex = 3;
            btnComparar.Text = "  Comparar resultados";
            btnComparar.TextAlign = ContentAlignment.MiddleLeft;
            btnComparar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnComparar.UseVisualStyleBackColor = true;
            btnComparar.Click += btnComparar_Click;
            // 
            // btnOrdenamiento
            // 
            btnOrdenamiento.Dock = DockStyle.Top;
            btnOrdenamiento.FlatAppearance.BorderSize = 0;
            btnOrdenamiento.FlatStyle = FlatStyle.Flat;
            btnOrdenamiento.Font = new Font("Segoe UI", 10F);
            btnOrdenamiento.ForeColor = Color.AliceBlue;
            btnOrdenamiento.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrdenamiento.ImageIndex = 3;
            btnOrdenamiento.ImageList = FormIcons;
            btnOrdenamiento.Location = new Point(0, 227);
            btnOrdenamiento.Name = "btnOrdenamiento";
            btnOrdenamiento.Padding = new Padding(12, 0, 0, 0);
            btnOrdenamiento.Size = new Size(303, 68);
            btnOrdenamiento.TabIndex = 2;
            btnOrdenamiento.Text = "  Algoritmos de Ordenamiento";
            btnOrdenamiento.TextAlign = ContentAlignment.MiddleLeft;
            btnOrdenamiento.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrdenamiento.UseVisualStyleBackColor = true;
            btnOrdenamiento.Click += btnOrdenamiento_Click;
            // 
            // btnBusqueda
            // 
            btnBusqueda.Dock = DockStyle.Top;
            btnBusqueda.FlatAppearance.BorderSize = 0;
            btnBusqueda.FlatStyle = FlatStyle.Flat;
            btnBusqueda.Font = new Font("Segoe UI", 10F);
            btnBusqueda.ForeColor = Color.AliceBlue;
            btnBusqueda.ImageAlign = ContentAlignment.MiddleLeft;
            btnBusqueda.ImageIndex = 4;
            btnBusqueda.ImageList = FormIcons;
            btnBusqueda.Location = new Point(0, 162);
            btnBusqueda.Name = "btnBusqueda";
            btnBusqueda.Padding = new Padding(12, 0, 0, 0);
            btnBusqueda.Size = new Size(303, 65);
            btnBusqueda.TabIndex = 1;
            btnBusqueda.Text = "  Algoritmos de Búsqueda";
            btnBusqueda.TextAlign = ContentAlignment.MiddleLeft;
            btnBusqueda.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBusqueda.UseVisualStyleBackColor = true;
            btnBusqueda.Click += btnBusqueda_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 10F);
            btnHome.ForeColor = Color.AliceBlue;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.ImageIndex = 6;
            btnHome.ImageList = FormIcons;
            btnHome.Location = new Point(0, 95);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(12, 0, 0, 0);
            btnHome.Size = new Size(303, 67);
            btnHome.TabIndex = 0;
            btnHome.Text = "  Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(303, 95);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(303, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelDock
            // 
            panelDock.BackColor = SystemColors.Window;
            panelDock.Controls.Add(panelTitle);
            panelDock.Dock = DockStyle.Fill;
            panelDock.Location = new Point(303, 0);
            panelDock.Name = "panelDock";
            panelDock.Size = new Size(1060, 721);
            panelDock.TabIndex = 1;
            panelDock.Paint += panelDock_Paint;
            // 
            // panelTitle
            // 
            panelTitle.BackColor = Color.Black;
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(0, 0);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(1060, 95);
            panelTitle.TabIndex = 0;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1363, 721);
            Controls.Add(panelDock);
            Controls.Add(panelSideBar);
            Name = "FrmPrincipal";
            Text = "Algoritmos de búsqueda y Ordenamiento";
            Load += Form1_Load;
            panelSideBar.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelDock.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideBar;
        private Panel panelLogo;
        private Button btnBusqueda;
        private Panel panelDock;
        private ImageList FormIcons;
        private Button btnSalir;
        private Button btnComparar;
        private Button btnOrdenamiento;
        private Button btnAjustes;
        private Panel panelTitle;
        private Button btnHome;
        private PictureBox pictureBox1;
    }
}
