using ProyectoFinal.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FrmPrincipal : Form
    {
        // 1. Instancias persistentes para guardar el progreso
        private FrmHome frmHome;
        private FrmBusqueda frmBusqueda;
        private FrmOrdenamiento frmOrdenamiento;
        private FrmComparar frmComparar;

        // Variable para controlar qué formulario se ve actualmente
        private Form activeForm = null;

        public FrmPrincipal()
        {
            InitializeComponent();
            ConfigurarEstilo();

            // 2. Inicializamos los formularios UNA SOLA VEZ
            // Al crearlos aquí, se mantienen vivos en memoria RAM con sus datos
            frmHome = new FrmHome();
            frmBusqueda = new FrmBusqueda();
            frmOrdenamiento = new FrmOrdenamiento();
            frmComparar = new FrmComparar();

            // 3. Abrimos el Home automáticamente al iniciar
            AbrirFormulario(frmHome, btnHome);
        }

        private void ConfigurarEstilo()
        {
            panelTitle.BackColor = System.Drawing.ColorTranslator.FromHtml("#39394B");
            panelDock.BackColor = System.Drawing.ColorTranslator.FromHtml("#E2E2EA");
        }

        // --- MÉTODO CORREGIDO: Abrir sin borrar datos ---
        private void AbrirFormulario(Form childForm, object btnSender)
        {
            // Si intentamos abrir el mismo que ya vemos, no hacemos nada
            if (activeForm == childForm) return;

            // En lugar de cerrar (.Close), solo ocultamos (.Hide) el anterior
            if (activeForm != null)
            {
                activeForm.Hide();
            }

            activeForm = childForm;

            // Solo configuramos el formulario si es la PRIMERA vez que se agrega al panel
            if (!this.panelDock.Controls.Contains(childForm))
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                this.panelDock.Controls.Add(childForm);
                this.panelDock.Tag = childForm;
            }

            // Mostramos el formulario (que conserva sus datos)
            childForm.BringToFront();
            childForm.Show();
            lblHeader.Text = childForm.Text;


            // Caso especial: Si abrimos Comparar, forzamos que actualice la gráfica
            // para que lea los nuevos datos que pudimos haber generado en otras pestañas
            if (childForm is FrmComparar comparador)
            {
                comparador.ActualizarGrafica();
            }
        }

        // --- EVENTOS DE BOTONES (Usamos las variables, no 'new') ---

        private void btnHome_Click(object sender, EventArgs e)
        {
            AbrirFormulario(frmHome, sender);
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            AbrirFormulario(frmBusqueda, sender);
        }

        private void btnOrdenamiento_Click(object sender, EventArgs e)
        {
            AbrirFormulario(frmOrdenamiento, sender);
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            AbrirFormulario(frmComparar, sender);
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            // Ajustes suele ser una ventana modal o temporal, aquí sí puedes usar 'new' si prefieres
            AbrirFormulario(new FrmAjustes(), sender);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Estás seguro que quieres salir del programa?",
                "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes) Application.Exit();
            else this.Focus();
        }


        // Eventos vacíos
        private void Form1_Load(object sender, EventArgs e) { }
        private void panelSideBar_Paint(object sender, PaintEventArgs e) { }
        private void panelDock_Paint(object sender, PaintEventArgs e) { }
    }
}