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
    public partial class FormAddCurso : Form
    {
        private int maximaCantidadAlumnoCurso = 50;

        public FormAddCurso()
        {
            InitializeComponent();
        }

        public FormAddCurso(Curso cursoEditar)
        {
            InitializeComponent();
        }

        public Administrador admnistradorLogueado { get; set; }

        private void txtNameCurso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbCurso.Focus();
            }
        }
        private void txtNameCurso_Leave(object sender, EventArgs e)
        {
            txtNameCurso.Text = txtNameCurso.Text.ToUpper();     
        }

        private void txtCantidadAlumnos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAceptar.Focus();
            }
        }
        private void txtCantidadAlumnos_Leave(object sender, EventArgs e)
        {
            var numeroOk = Validador.ValidarCantidadAlumnos(txtCantidadAlumnos.Text, maximaCantidadAlumnoCurso);
            LogicaForm.ComportamientoCajaDeTexto(numeroOk, txtCantidadAlumnos, lblError);
        }
        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCantidadAlumnos.Focus();
            }
        }
        private void txtDescription_Leave(object sender, EventArgs e)
        {
            txtDescription.Text = txtDescription.Text.ToUpper();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNameCurso.Text == "")
            {
                LogicaForm.ComportamientoCajaDeTexto(false, txtNameCurso, lblError);
                return;
            }

            int numero = 0;
            string codigoCurso = "";
            
            try
            {
                numero = int.Parse(txtCantidadAlumnos.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("El valor ingresado no es un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidadAlumnos.Focus();
            }

            //Curso curso = new Curso(txtNameCurso.Text, txtCodCurso.Text, txtDescription.Text, numero);
            if (cbCurso.SelectedIndex != -1 && cbAsignatura.SelectedIndex != -1)
            {
                codigoCurso = FormatoStringCurso();
                //curso.CodigoCurso = FormatoStringCurso();
            }

            if (cbDiasCursada.SelectedIndex != -1 && cbTurnos.SelectedIndex != -1 && listHorarios.SelectedIndex != -1)
            {
                string dia = cbDiasCursada.SelectedItem.ToString();
                string turno = cbTurnos.SelectedItem.ToString();
                //curso.TurnoCursada = cbTurnos.SelectedItem.ToString();
                string horario = listHorarios.SelectedItem.ToString();
                //curso.HorarioCursada = listHorarios.SelectedItem.ToString();
                Curso curso = new Curso(codigoCurso, txtNameCurso.Text, txtDescription.Text, numero, turno, dia, horario);
                
                if (Validador.ValidarExistenciaDeRegistro(curso))
                {
                    DataBase.DataBaseOpGuardar(curso);
                    string aux = admnistradorLogueado.Nombre;
                    //Curso curso = new Curso(codigoCurso, txtNameCurso.Text, txtDescription.Text, numero, turno, horario);
                    DataBase.DataBaseOpGuardar(curso);
                    //admnistradorLogueado.AltaCurso(curso);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("EL REGISTRO YA EXISTE");
                    cbCurso.Focus();
                    //this.Close();
                }
            }
            else
            {
                MessageBox.Show("DEBE IDENTIFICAR CORRECTAMENTE EL HORARIO DE CURSADA", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // PRUEBA
            //Curso prueba = new Curso("2", "JAZMIN", "GENIA", 30,"TARDE","VIERNES","18:00");
            //DataBase.DataBaseOpGuardar(prueba);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea abandonar la carga?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();

            }            
        }

        private void cbTurnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            listHorarios.Items.Clear();
            string turno = cbTurnos.SelectedItem.ToString();
            LogicaForm.SeleccionHorarioPorTurno(turno, listHorarios);
        }

        private void FormAddCurso_Load(object sender, EventArgs e)
        {            
            CargaCursosEnLista();
        }

        private void CargaCursosEnLista()
        {
            LogicaForm.CargarDataGridViewCursos(dgCursos);
        }

        private string FormatoStringCurso() => $"C{cbCurso.SelectedItem.ToString()}A{cbAsignatura.SelectedItem.ToString()}";

        private void cbAsignatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodCurso.Text = FormatoStringCurso();
        }

        private void cbDiasCursada_Enter(object sender, EventArgs e)
        {
            cbDiasCursada.DataSource = Enum.GetValues(typeof(Horarios.Dias));
            cbTurnos.DataSource = Enum.GetValues(typeof(Horarios.Turno));
        }

    }
}
