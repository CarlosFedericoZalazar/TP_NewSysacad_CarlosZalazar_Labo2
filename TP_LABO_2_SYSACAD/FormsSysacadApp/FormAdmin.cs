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
        public FormAdmin()
        {
            InitializeComponent();
        }

        public Administrador admnistradorLogueado { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.formularioRegEstudiante = new FormRegStudent();
            Program.formularioRegEstudiante.admnistradorLogueado = admnistradorLogueado;
            Program.formularioRegEstudiante.Show();

            this.Hide();
            //Program.formularioRegEstudiante.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Program.formularioAdminCursos = new FormAdminCursos();
            Program.formularioAdminCursos.admnistradorLogueado = admnistradorLogueado;
            Program.formularioAdminCursos.Show();
            Program.formularioAdministrador.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿DESEA CERRAR LA SESIÓN?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormLogin formularioLogin = new FormLogin();
            formularioLogin.Show();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            lblAdminLogued.Text = $"Admin: {admnistradorLogueado.Apellido}, {admnistradorLogueado.Nombre}";
        }
    }
}
