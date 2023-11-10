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
    public partial class FormAlumno : Form
    {
        private FormLogin _formularioLogin;
        
        public FormAlumno(FormLogin formularioLogin)
        {
            InitializeComponent();
            _formularioLogin = formularioLogin;
            
        }

        public Alumno alumnoLogueado { get; set; }

        private void FormAlumno_Load(object sender, EventArgs e)
        {
            lblAlumnoLogued.Text = $"Estudiante: {alumnoLogueado.Nombre}";
        }

        private void btnInscipCursos_Click(object sender, EventArgs e)
        {
            FormInscripCursosAlum formularioInscripcionCursos = new FormInscripCursosAlum(this);
            formularioInscripcionCursos.alumnoLogueado = alumnoLogueado;
            formularioInscripcionCursos.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿DESEA CERRAR LA SESIÓN?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FormAlumno_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormLogin formularioLogin = new FormLogin();
            formularioLogin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormHorarioAlumno formualrioHorarioAlumno = new FormHorarioAlumno();
            formualrioHorarioAlumno.alumnoLogueado = alumnoLogueado;
            formualrioHorarioAlumno.Show();
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            FormPagoAlumnos formularioPagoAlumno = new FormPagoAlumnos();
            formularioPagoAlumno.alumnoLogueado = alumnoLogueado;
            this.Hide();
            formularioPagoAlumno.Show();
        }

    }
}
