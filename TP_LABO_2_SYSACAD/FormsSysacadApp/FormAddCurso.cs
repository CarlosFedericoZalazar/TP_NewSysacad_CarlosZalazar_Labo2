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
    public enum Turno
    {
        MAÑANA,
        TARDE,
        NOCHE
    }
    public partial class FormAddCurso : Form
    {
        private int maximaCantidadAlumnoCurso = 50;

        public FormAddCurso()
        {
            InitializeComponent();
        }

        public Administrador admnistradorLogueado { get; set; }

        private void txtNameCurso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCodCurso.Focus();
            }
        }
        private void txtNameCurso_Leave(object sender, EventArgs e)
        {
            txtNameCurso.Text = txtNameCurso.Text.ToUpper();
            LogicaDeFormulario.ComportamientoCajaDeTexto(Validador.ValidarTexto(txtNameCurso.Text), txtNameCurso, lblError);

        }

        private void txtCodCurso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDescription.Focus();
            }
        }
        private void txtCodCurso_Leave(object sender, EventArgs e)
        {
            txtCodCurso.Text = txtCodCurso.Text.ToUpper();
            LogicaDeFormulario.ComportamientoCajaDeTexto(Validador.ValidarCurso(txtCodCurso.Text), txtCodCurso, lblError);
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
            LogicaDeFormulario.ComportamientoCajaDeTexto(numeroOk, txtCantidadAlumnos, lblError);
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
            LogicaDeFormulario.ComportamientoCajaDeTexto(Validador.ValidarTexto(txtDescription.Text), txtDescription, lblError);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int numero = 0;
            try
            {                
                numero = int.Parse(txtCantidadAlumnos.Text);                
            }
            catch (FormatException)
            {                
                MessageBox.Show("El valor ingresado no es un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidadAlumnos.Focus();
            }        
            
            Curso curso = new Curso(txtNameCurso.Text, txtCodCurso.Text, txtDescription.Text, numero);          
          

            if (cbDiasCursada.SelectedIndex != -1 && cbTurnos.SelectedIndex != -1 && listHorarios.SelectedIndex != -1)
            {
                curso.DiasCursada = cbDiasCursada.SelectedItem.ToString();
                curso.TurnoCursada = cbTurnos.SelectedItem.ToString();
                curso.HorarioCursada = listHorarios.SelectedItem.ToString();

                if (Validador.ValidarExistenciaDeRegistro(curso))
                {
                    string aux = admnistradorLogueado.Nombre;
                    admnistradorLogueado.AltaCurso(curso);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("EL REGISTRO YA EXISTE");
                    txtCodCurso.Focus();
                    //this.Close();
                }
            }
            else
            {
                MessageBox.Show("DEBE IDENTIFICAR CORRECTAMENTE EL HORARIO DE CURSADA", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

            LogicaDeFormulario.SeleccionHorarioPorTurno(turno, listHorarios);            
        }

        private void FormAddCurso_Load(object sender, EventArgs e)
        {            
            cbTurnos.DataSource = Enum.GetValues(typeof(Turno));
            LogicaDeFormulario.ActualizarContenidoListBoxes(lbCursos);
        }

        private void cbDiasCursada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
