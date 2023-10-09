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
    public partial class FormRegStudent : Form
    {
        List<Alumno> listaAlumnos = new List<Alumno>();
        
        public FormRegStudent()
        {
            InitializeComponent();
        }

        public Administrador admnistradorLogueado { get; set; }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSurname.Focus(); 
            }
        }
        private void txtName_Leave(object sender, EventArgs e)
        {
            LogicaDeFormulario.ComportamientoCajaDeTexto(Validador.ValidarTexto(txtName.Text), txtName,lblError);
        }

        private void txtSurname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDocument.Focus();                
            }
        }

        private void txtSurname_Leave(object sender, EventArgs e)
        {
            LogicaDeFormulario.ComportamientoCajaDeTexto(Validador.ValidarTexto(txtSurname.Text), txtSurname,lblError);
        }

        private void txtDocument_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtStreet.Focus();
            }
        }

        private void txtDocument_Leave(object sender, EventArgs e)
        {
            LogicaDeFormulario.ComportamientoCajaDeTexto(Validador.ValidarNumeros(txtDocument.Text), txtDocument,lblError);
        }

        private void txtStreet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNumStreet.Focus();
            }
        }

        private void txtStreet_Leave(object sender, EventArgs e)
        {
            LogicaDeFormulario.ComportamientoCajaDeTexto(Validador.ValidarTexto(txtStreet.Text), txtNumStreet, lblError);
        }

        private void txtCity_KeyDown(object sender, KeyEventArgs e)
        {
            txtDepto.Focus();
        }
        private void txtDepto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCity.Focus();
            }
        }
        private void txtCity_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
            }            
        }
        private void txtCity_Leave(object sender, EventArgs e)
        {
            LogicaDeFormulario.ComportamientoCajaDeTexto(Validador.ValidarTexto(txtStreet.Text), txtEmail,lblError);
        }

        private void txtNumStreet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDepto.Focus();
            }           
        }

        private void txtDepto_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCity.Focus();
            }
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistrar.Focus();
            }            
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPhone.Focus();
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string stringDireccion = $"{txtStreet.Text} {txtNumStreet.Text} {txtDepto.Text}, {txtCity.Text}";
            Alumno estudiante = new Alumno(txtName.Text, txtSurname.Text, txtDocument.Text, "0", "0", checkChangePass.Checked,stringDireccion, txtEmail.Text, txtPhone.Text);
            ConfirmarDatos(estudiante);      
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.formularioAdministrador.Show();
        }

        private void ConfirmarDatos(Alumno estudiante) 
        {
            string informacionEstudiante = "";

            StringBuilder sbListarinformacion = new StringBuilder();
            sbListarinformacion.AppendLine(estudiante.Nombre);
            sbListarinformacion.AppendLine(estudiante.Dni);
            sbListarinformacion.AppendLine(estudiante.Direccion);
            sbListarinformacion.AppendLine(estudiante.Email);
            sbListarinformacion.AppendLine(estudiante.Telefono);
            informacionEstudiante = sbListarinformacion.ToString();

            DialogResult resultado = MessageBox.Show($"{informacionEstudiante}\n¿CONFIRMA LA CARGA?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                estudiante.Password = GestorDeClases.Hash.GenerarHash(estudiante.Dni);

                estudiante.Legajo = admnistradorLogueado.AsignarLegajoAlumno();
                admnistradorLogueado.AltaRegistro(estudiante);

                resultado = MessageBox.Show($"Desea cargar otro registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    this.Close();
                    FormRegStudent formularioRegistroEstudiante = new FormRegStudent();
                    formularioRegistroEstudiante.admnistradorLogueado = admnistradorLogueado;
                    formularioRegistroEstudiante.Show();

                }
                else
                {
                    Program.formularioAdministrador.Show();
                    this.Close();
                }

                //infoEstudiante.EnviarCredenciales(infoEstudiante);                
            }
            else
            {
                // Código para continuar con la carga
            }




        }
    }

}
