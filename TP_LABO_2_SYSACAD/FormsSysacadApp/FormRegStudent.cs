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
        private FormAdmin formularioAdmin;
        public FormRegStudent(FormAdmin formularioAdministrador)
        {
            InitializeComponent();            
            formularioAdmin = formularioAdministrador;
            txtName.LostFocus += (sender, e) => ConvertirAMayusculas(txtName);
            txtSurname.LostFocus += (sender, e) => ConvertirAMayusculas(txtSurname);
            txtEmail.LostFocus += (sender, e) => ConvertirAMayusculas(txtEmail);


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
            txtName.Text.ToUpper();
            //LogicaDeFormulario.ComportamientoCajaDeTexto(Validador.ValidarTexto(txtName.Text), txtName,lblError);
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
            txtSurname.Text.ToUpper();
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
            txtPassProvisional.Text = txtDocument.Text;
            //LogicaDeFormulario.ComportamientoCajaDeTexto(Validador.ValidarNumeros(txtDocument.Text), txtDocument,lblError);
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
            txtStreet.Text.ToUpper();
        }

        private void txtCity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
            }            
        }
        private void txtCity_Leave(object sender, EventArgs e)
        {
            txtCity.Text.ToUpper();
        }

        private void txtNumStreet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDepto.Focus();
            }           
        }

        private void txtDepto_KeyDown(object sender, KeyEventArgs e)
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
            bool comprobartxtNomApellido = ValidacionTextNombreApellido();
            bool comprobarTxtDni = ValidacionTextdni(txtDocument);
            bool comprobarTxtVacios = ValidarTextosVacios();
            bool comprobarTxtEmail = ValidarFormatoEmail();
            bool comprobarTxTelefono = ValidarFormatoTelefono();


            string stringDireccion = $"{txtStreet.Text} {txtNumStreet.Text} {txtDepto.Text}, {txtCity.Text}";
                       
            Alumno estudiante = new Alumno(txtName.Text, txtSurname.Text, txtDocument.Text, "0", "0", checkChangePass.Checked,stringDireccion, txtEmail.Text, txtPhone.Text);
            if (Validador.ValidarExistenciaDeRegistro(estudiante))
            {
                ConfirmarDatos(estudiante);
            }
            else
            {
                DialogResult resultado = MessageBox.Show($"El registro Ya existe, desea intentar cargar nuevamente?", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDocument.Focus();
            }                  
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            formularioAdmin.Show();            
         }

        private void ConfirmarDatos(Alumno estudiante) 
        {            

            StringBuilder sbListarinformacion = new StringBuilder();
            sbListarinformacion.AppendLine(estudiante.Nombre);
            sbListarinformacion.AppendLine(estudiante.Dni);
            sbListarinformacion.AppendLine(estudiante.Direccion);
            sbListarinformacion.AppendLine(estudiante.Email);
            sbListarinformacion.AppendLine(estudiante.Telefono);
            lblInfoEstudiante.Text = sbListarinformacion.ToString();

            DialogResult resultado = MessageBox.Show($"¿CONFIRMA LA CARGA?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                estudiante.Password = GestorDeClases.Hash.GenerarHash(estudiante.Dni);

                estudiante.Legajo = admnistradorLogueado.AsignarLegajoAlumno();
                admnistradorLogueado.AltaEstudiante(estudiante);

                resultado = MessageBox.Show($"Desea cargar otro registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    this.Close();
                    FormRegStudent formularioRegistroEstudiante = new FormRegStudent(formularioAdmin);
                    formularioRegistroEstudiante.admnistradorLogueado = admnistradorLogueado;
                    formularioRegistroEstudiante.Show();
                }
                else
                {
                    formularioAdmin.Show();                    
                    this.Close();
                }

                //infoEstudiante.EnviarCredenciales(infoEstudiante);                
            }
            else
            {
                txtName.Focus();
            }

        }
        // VALIDACIONES
        private bool ValidacionTextNombreApellido() 
        {
            bool validacionOk = true;

            List<TextBox> listaNombreApellido = new List<TextBox>();
            listaNombreApellido.Add(txtName);
            listaNombreApellido.Add(txtSurname);            
            validacionOk = LogicaDeFormulario.ValidarNombreApellido(listaNombreApellido,lblError);
            return validacionOk;
        }

        private bool ValidacionTextdni(TextBox txtDni) 
        {
            bool validacionOk = true;
            validacionOk=LogicaDeFormulario.ValidarDni(txtDni);
            return validacionOk;
        }

        private bool ValidarTextosVacios() 
        {
            bool validacionOk = true;
            List<TextBox> listaCajasTexto = new List<TextBox>();
            listaCajasTexto.Add(txtStreet);
            listaCajasTexto.Add(txtNumStreet);
            listaCajasTexto.Add(txtCity);
            listaCajasTexto.Add(txtPhone);
            validacionOk = LogicaDeFormulario.ValidarTextosVacios(listaCajasTexto, lblError);
            return validacionOk;
        }

        private bool ValidarFormatoEmail() 
        {
            bool validacionOk = false;
            validacionOk = LogicaDeFormulario.ValidarTextoMail(txtEmail,lblError);
            return validacionOk;        
        }

        private bool ValidarFormatoTelefono()
        {
            bool validacionOk = false;
            validacionOk = Validador.ValidarNumeros(txtPhone.Text);
            return validacionOk;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int PosX =  txtPhone.Location.X;
            int PosY = txtPhone.Location.Y+25;
            
            lblError.Location = new System.Drawing.Point(PosX, PosY);
            lblError.Visible = true;
            
        }

        private void FormRegStudent_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        //private void txtName_TextChanged(object sender, EventArgs e)
        //{
        //    TextBox textBox = (TextBox)sender;
        //    textBox.Text = textBox.Text.ToUpper();
        //    textBox.SelectionStart = textBox.Text.Length;
        //}

        private void ConvertirAMayusculas(TextBox textBox)
        {
            textBox.Text = textBox.Text.ToUpper();
            textBox.SelectionStart = textBox.Text.Length; // Coloca el cursor al final del texto
        }

    }

}
