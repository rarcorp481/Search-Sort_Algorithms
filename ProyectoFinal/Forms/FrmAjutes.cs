using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinal.Forms
{
    public partial class FrmAjustes : Form
    {
        public FrmAjustes()
        {
            InitializeComponent();
            CargarConfiguracionActual();
        }

        private void CargarConfiguracionActual()
        {
            // Sincroniza el fondo actual con la variable global
            this.BackColor = DatosGlobales.ColorFondo;
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            ColorDialog selectorColor = new ColorDialog();

            // Permitir seleccionar colores personalizados
            selectorColor.AllowFullOpen = true;
            selectorColor.Color = DatosGlobales.ColorFondo;

            if (selectorColor.ShowDialog() == DialogResult.OK)
            {
                // 1. Guardamos el nuevo color en la variable estática global
                DatosGlobales.ColorFondo = selectorColor.Color;

                // 2. Aplicamos el cambio inmediatamente a este formulario para dar feedback
                this.BackColor = DatosGlobales.ColorFondo;

                MessageBox.Show("El color ha sido guardado.\nLos cambios se reflejarán al abrir nuevamente los otros formularios.",
                                "Configuración Guardada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }
    }
}