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
    public partial class FormListarInformacion : Form
    {
        public FormListarInformacion()
        {
            InitializeComponent();
        }

        public Alumno infoEstudiante { get; set; }

        public Administrador administradorLogueado { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {            
            this.Close(); 
        }

        private void FormListarInformacion_Load(object sender, EventArgs e)
        {
            StringBuilder sbListarinformacion = new StringBuilder();
            sbListarinformacion.AppendLine(infoEstudiante.Nombre);
            sbListarinformacion.AppendLine(infoEstudiante.Dni);
            sbListarinformacion.AppendLine(infoEstudiante.Direccion);
            sbListarinformacion.AppendLine(infoEstudiante.Email);
            sbListarinformacion.AppendLine(infoEstudiante.Telefono);
            label1.Text = sbListarinformacion.ToString();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Validador.ValidarExistenciaDeRegistro(infoEstudiante))
            {
                infoEstudiante.Legajo = administradorLogueado.AsignarLegajoAlumno();
                administradorLogueado.AltaRegistro(infoEstudiante);             
                MessageBox.Show("REGISTRO CARGADO");
                this.Close();
                infoEstudiante.EnviarCredenciales(infoEstudiante);
                Program.formularioRegEstudiante.Close();
            }
            else
            {
                MessageBox.Show("EL REGISTRO YA EXISTE");
                this.Close();
                FormRegStudent formularioRegistroEstudiante = new FormRegStudent();
            }
        }
    }
}
