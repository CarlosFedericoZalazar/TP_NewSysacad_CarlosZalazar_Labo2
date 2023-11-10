using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaClasesTP;

namespace FormsSysacadApp
{
    public partial class FormAdmin : Form
    {
        private FormLogin formularioLogin;
        public FormAdmin(FormLogin formularioAdministrador)
        {
            InitializeComponent();
            formularioLogin = formularioAdministrador;
        }

        public Administrador admnistradorLogueado { get; set; }

        private void btnRegEstudiante_Click(object sender, EventArgs e)
        {
            FormRegStudent formularioRegEstudiante = new FormRegStudent(this);
            formularioRegEstudiante.admnistradorLogueado = admnistradorLogueado;
            this.Hide();
            formularioRegEstudiante.Show();
        }

        private void btnGestionCurso_Click_1(object sender, EventArgs e)
        {            
            FormAdminCursos formularioAdminCursos = new FormAdminCursos(this);
            this.Hide();
            formularioAdminCursos.admnistradorLogueado = admnistradorLogueado;
            formularioAdminCursos.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿DESEA CERRAR LA SESIÓN?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                formularioLogin.Show();
                this.Close();
            }
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            //FormLogin formularioLogin = new FormLogin();
            //formularioLogin.Show();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            lblAdminLogued.Text = $"Admin: {admnistradorLogueado.Apellido}, {admnistradorLogueado.Nombre}";
        }
    }
}
