using ProyectoFinal.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FrmPrincipal : Form
    {
        // Instancias persistentes
        private FrmHome frmHome;
        private FrmBusqueda frmBusqueda;
        private FrmOrdenamiento frmOrdenamiento;
        private FrmComparar frmComparar;
        private Form formularioActivo;

        public FrmPrincipal()
        {
            InitializeComponent();
            ConfigurarEstilo();

            // Inicialización única
            frmHome = new FrmHome();
            frmBusqueda = new FrmBusqueda();
            frmOrdenamiento = new FrmOrdenamiento();
            frmComparar = new FrmComparar();

            // Inicio
            AbrirFormulario(frmHome);
        }

        private void ConfigurarEstilo()
        {
            if (panelTitle != null) panelTitle.BackColor = System.Drawing.ColorTranslator.FromHtml("#39394B");
            if (panelDock != null) panelDock.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E2EA");
        }

        private void AbrirFormulario(Form childForm)
        {
            if (formularioActivo == childForm) return;
            if (formularioActivo != null) formularioActivo.Hide();

            formularioActivo = childForm;

            if (!panelDock.Controls.Contains(childForm))
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelDock.Controls.Add(childForm);
                panelDock.Tag = childForm;
            }
            
            childForm.BringToFront();
            childForm.Show();
            lblHeader.Text = childForm.Text;
        }

        // Eventos de Botones
        private void btnHome_Click(object sender, EventArgs e) => AbrirFormulario(frmHome);
        private void btnBusqueda_Click(object sender, EventArgs e) => AbrirFormulario(frmBusqueda);
        private void btnOrdenamiento_Click(object sender, EventArgs e) => AbrirFormulario(frmOrdenamiento);
        private void btnComparar_Click(object sender, EventArgs e) => AbrirFormulario(frmComparar);

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            using (FrmAjustes ajustes = new FrmAjustes())
            {
                if (ajustes.ShowDialog() == DialogResult.OK) ConfigurarEstilo();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Salir de la aplicación?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        // Eventos vacíos del designer (no borrar o se jode todo)
        private void Form1_Load(object sender, EventArgs e) { }
        private void panelSideBar_Paint(object sender, PaintEventArgs e) { }
        private void panelDock_Paint(object sender, PaintEventArgs e) { }
    }
}