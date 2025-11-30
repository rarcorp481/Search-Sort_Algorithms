using ProyectoFinal.Forms;

namespace ProyectoFinal
{
    public partial class FrmPrincipal : Form
    {

        private Form activeForm;
        public FrmPrincipal()
        {
            InitializeComponent();
            panelTitle.BackColor = System.Drawing.ColorTranslator.FromHtml("#39394B");
            panelDock.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E2EA");
        }

        // Home Button
        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmHome(), sender);
        }

        // Comparar Button
        private void btnComparar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmComparar(), sender);
        }

        // Ordenamiento Button
        private void btnOrdenamiento_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmOrdenamiento(), sender);
        }

        // Busqueda Button
        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmBusqueda(), sender);

        }

        // Salir Button
        private void btnSalir_Click(object sender, EventArgs e)
        {
           DialogResult respuesta = MessageBox.Show("Estás seguro que quieres salir del programa?" , "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes) Application.Exit();
            else this.Focus();


        }

        // Métodos auxiliares

        // Abrir formularios hijos dentro del panelDock
        private void OpenChildForm(Form ChildForm, object btnSender)
        {
            if (ActiveForm != null)
            {
                activeForm.Close();
            }
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            this.panelDock.Controls.Add(ChildForm);
            this.panelDock.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        // Elementos del FrmPrincipal
        private void Form1_Load(object sender, EventArgs e) { }
        private void panelSideBar_Paint(object sender, PaintEventArgs e) { }
        private void panelDock_Paint(object sender, PaintEventArgs e) { }


    }
}
