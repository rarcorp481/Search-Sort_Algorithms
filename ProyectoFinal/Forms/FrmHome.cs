using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinal.Forms
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
            ConfigurarEstilo();
        }

        private void ConfigurarEstilo()
        {
            // Aplicamos el color global definido en Program.cs
            this.BackColor = DatosGlobales.ColorFondo;
        }
    }
}