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
using System.IO;


namespace FormsSysacadApp
{    
    public partial class FormLogin : Form
    {        
        public FormLogin()
        {
            InitializeComponent();
            //CrearNuevoAdministrador();
            Console.WriteLine("Inicio del Programa");
        }

        private void buttonAceptar_Click_1(object sender, EventArgs e)
        {  
            bool typeUserAdmin =  Validador.ValidarAdministrador(txtUsuario.Text);
            SelectTypeUser(typeUserAdmin);                

        }
        /// <summary>
        /// PROCEDE A LA APERTURA DE FORMULARIO DEPENDIENDO EL TIPO DE USUARIO
        /// </summary>
        /// <param name="typeUserAdmin">BOOL: TRUE/ADMINISTRADOR, FALSE/ALUMNO</param>
        private void SelectTypeUser(bool typeUserAdmin) 
        {
            var listasUsuarios = Datos.Abrir();
            if (typeUserAdmin)
            {                
                var administradorSelect = Validador.ValidarExistenciaUser(listasUsuarios.Administradores, txtUsuario.Text, txtPass.Text);
                if (administradorSelect != null)
                {
                    AperturaFormularioAdministrador(administradorSelect);
                }
            }
            else 
            {
                try
                {
                    Alumno alumnoSelect = Validador.ValidarExistenciaUser(listasUsuarios.Estudiantes,txtUsuario.Text, txtPass.Text);
                    if (alumnoSelect == null)
                    {
                        throw new MyExceptions.ValorNullException("El valor no puede ser nulo.");
                    }
                    else 
                    {
                        AperturaFormularioAlumno(alumnoSelect);
                    }                    
                }
                catch (MyExceptions.ValorNullException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    MessageBox.Show("USUARIO INEXISTENTE", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblUserError.Visible = true;
                    txtUsuario.Focus();
                }
            }
        }
        /// <summary>
        /// INSTANCIA UN FORMULARIO ADMINISTRADOR
        /// </summary>
        /// <param name="administrador">ADMNISTRADOR LOGUEADO</param>
        
        private void AperturaFormularioAdministrador(Administrador administrador)
        {
            //Program.formularioAdministrador = new FormAdmin();
            //Program.formularioAdministrador.admnistradorLogueado = administrador;            
            //Program.formularioAdministrador.Show();
            //this.Hide();

            FormAdmin formularioAdministrador = new FormAdmin(this);
            formularioAdministrador.admnistradorLogueado = administrador;
            formularioAdministrador.Show();
            this.Hide();


        }

        /// <summary>
        /// INSTANCIA UN FORMULARIO ALUMNO
        /// </summary>
        /// <param name="administrador">ALUMNO LOGUEADO</param>
        private void AperturaFormularioAlumno(Alumno alumnoSelect)
        {            
            Program.formularioAlumno = new FormAlumno();
            Program.formularioAlumno.alumnoLogueado = alumnoSelect;
            Program.formularioAlumno.Show();            
            this.Hide();

        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPass.Focus();
            }
        }

        private void btnLogAdmin_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "admin114005";
            txtPass.Text = "1234";            
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAceptar.Focus();
            }
        }
        /// <summary>
        /// HARCODE DOS ADMNISTRADORES PARA HACER PRUEBAS
        /// </summary>
        private void CrearNuevoAdministrador()
        {
            string hash1 = GestorDeClases.Hash.GenerarHash("1234");
            string hash2 = GestorDeClases.Hash.GenerarHash("1234");
            Administrador nuevoAdmnistrador = new Administrador("Lionel", "Tramontini", "admin1122", hash1);
            Administrador nuevoAdmnistrador2 = new Administrador("Carlos", "Zalazar", "admin114005", hash2);
            ClaseMaestra listadminClaseMaestra = Datos.Abrir();
            listadminClaseMaestra.Administradores.Add(nuevoAdmnistrador);
            listadminClaseMaestra.Administradores.Add(nuevoAdmnistrador2);
            Datos.Guardar(listadminClaseMaestra);
        }

        private void btnLogAlumno_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "0";
            txtPass.Text = "44286438";
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtPass.Clear();
            txtUsuario.Clear();
        }
    }
}
            

