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
    public partial class FormEditCurso : Form
    {
        private int maximaCantidadAlumnoCurso = 50;

        public FormEditCurso()
        {
            InitializeComponent();
        }

        public Curso infoCurso { get; set; }
        public Administrador admnistradorLogueado { get; set; }

        private void FormEditCurso_Load(object sender, EventArgs e)
        {
            try
            {
                txtNombreCurso.Text = infoCurso.NombreCurso;
                txtCodigoCurso.Text = infoCurso.CodigoCurso;
                txtDescripCurso.Text = infoCurso.Descripcion;
                txtCantAlumCurso.Text = infoCurso.CantidadAlumnos.ToString();
                cbTurnos.Text = infoCurso.TurnoCursada;
                cbDiasCursada.Text = infoCurso.DiasCursada;
                listHorarios.Items.Add(infoCurso.HorarioCursada);
            }
            catch (NullReferenceException)
            {
                this.Close();
            }

        }

        private void txtNombreCurso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCodigoCurso.Focus();
            }
        }

        private void txtNombreCurso_Leave(object sender, EventArgs e)
        {
            txtNombreCurso.Text = txtNombreCurso.Text.ToUpper();
            LogicaDeFormulario.ComportamientoCajaDeTexto(Validador.ValidarTexto(txtNombreCurso.Text), txtNombreCurso, lblError);
        }

        private void txtCodigoCurso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDescripCurso.Focus();
            }
        }

        private void txtCodigoCurso_Leave(object sender, EventArgs e)
        {
            txtCodigoCurso.Text = txtCodigoCurso.Text.ToUpper();
            LogicaDeFormulario.ComportamientoCajaDeTexto(Validador.ValidarCurso(txtCodigoCurso.Text), txtCodigoCurso, lblError);
        }

        private void txtDescripCurso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCantAlumCurso.Focus();
            }
        }
        private void txtDescripCurso_Leave(object sender, EventArgs e)
        {
            txtDescripCurso.Text = txtDescripCurso.Text.ToUpper();
            LogicaDeFormulario.ComportamientoCajaDeTexto(Validador.ValidarTexto(txtDescripCurso.Text), txtDescripCurso, lblError);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {      
            
            DialogResult resultado = MessageBox.Show("¿Desea confirmar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
            if (resultado == DialogResult.Yes)
            {   
                var cursoModificado = new Curso(txtNombreCurso.Text, txtCodigoCurso.Text, txtDescripCurso.Text, int.Parse(txtCantAlumCurso.Text));

                if (cbDiasCursada.SelectedIndex == -1)
                {
                    cursoModificado.DiasCursada = infoCurso.DiasCursada;
                }
                else
                {
                    cursoModificado.DiasCursada = cbDiasCursada.SelectedItem.ToString();
                }

                if (cbTurnos.SelectedIndex == -1)
                {
                    cursoModificado.TurnoCursada = infoCurso.TurnoCursada;
                }
                else
                {
                    cursoModificado.TurnoCursada = cbTurnos.SelectedItem.ToString();
                }

                if (listHorarios.SelectedIndex == -1)
                {
                    cursoModificado.HorarioCursada = infoCurso.HorarioCursada;
                }
                else
                {
                    cursoModificado.HorarioCursada = listHorarios.SelectedItem.ToString();
                }

                    // VER ESTE ERROR!
                //    try
                //{
                //    cursoModificado.HorarioCursada = listHorarios.SelectedItem.ToString();
                //}
                //catch (Exception)
                //{
                //    MessageBox.Show("Debe seleccionar horario de Cursada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    listHorarios.Focus();
                //}

                admnistradorLogueado.ModificarRegistro(infoCurso, cursoModificado);

                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void txtCantAlumCurso_KeyDown(object sender, KeyEventArgs e)
        {            
            if (e.KeyCode == Keys.Enter)
            {
                btnAceptar.Focus();
            }
        }

        private void txtCantAlumCurso_Leave(object sender, EventArgs e)
        {
            var numeroOk = Validador.ValidarCantidadAlumnos(txtCantAlumCurso.Text, maximaCantidadAlumnoCurso);
            LogicaDeFormulario.ComportamientoCajaDeTexto(numeroOk, txtCantAlumCurso, lblError);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbTurnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            listHorarios.Items.Clear();
            string turno = cbTurnos.SelectedItem.ToString();
            

            LogicaDeFormulario.SeleccionHorarioPorTurno(turno, listHorarios);
        }

    }
}
