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
    public partial class FormInscripCursosAlum : Form
    {        
        List<Curso> listaCursos = GestorDeClases.ExtraerListaCursos();
        
        BindingList<Curso> cursosInscriptos = new BindingList<Curso>();


        private FormAlumno formularioAlumno;
        public FormInscripCursosAlum(FormAlumno formAlumno)
        {
            InitializeComponent();
            cbTurnos.SelectedIndex = 0;
            formularioAlumno = formAlumno;
            cbTurnos.DataSource = Enum.GetValues(typeof(Horarios.Turno));
        }

        public Alumno alumnoLogueado { get; set; }

        private void FormInscripCursosAlum_Load(object sender, EventArgs e)
        {
            LogicaForm.CargarDataGridViewCursos(dgCursos);
            cursosInscriptos = alumnoLogueado.RecuperarInscripcionMaterias(alumnoLogueado.Legajo);
            
            dgCursoInscripto.DataSource = cursosInscriptos;


            foreach (int columnIndex in new[] { 2, 3, 4, 5, 6, 7 })
            {
                dgCursoInscripto.Columns[columnIndex].Visible = false;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Curso cursoSeleccionado = (Curso)dgCursos.CurrentRow.DataBoundItem;

               bool cursoYaInscripto = Validador.ValidarCoincidenciaCodigoCurso(cursosInscriptos, cursoSeleccionado);
               if (cursoYaInscripto)
               {
                   MessageBox.Show("EL REGISTRO YA EXISTE", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               }
               else
               {
                   if (cursoSeleccionado.CantidadAlumnos != 0)
                   {
                      cursoSeleccionado.CantidadAlumnos -= 1;
                      cursoSeleccionado.CantidadInscriptos += 1;

                       DataBase.ModificarCurso(cursoSeleccionado, cursoSeleccionado.CodigoCurso);
                       dgCursos.Refresh();
                       cursosInscriptos.Add(cursoSeleccionado);
                   }
                   else
                   {
                       MessageBox.Show("NO QUEDAN MAS CUPOS PARA ESTE CURSO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   }
               }
            
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var cantidadMateriasInscriptas = alumnoLogueado.InscripcionMaterias(cursosInscriptos,alumnoLogueado.Legajo);
            if (cantidadMateriasInscriptas != 0)
            {
                MessageBox.Show($"Se ha Inscripto correctamente a {cantidadMateriasInscriptas} Cursos", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show($"No se ha registrado a nuevos cursos", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Close();
            formularioAlumno.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Curso cursoSeleccionado = (Curso)dgCursos.CurrentRow.DataBoundItem;
            cursoSeleccionado.CantidadAlumnos -= 1;

            DataBase.ModificarCurso(cursoSeleccionado, cursoSeleccionado.CodigoCurso);
            dgCursos.Refresh();
            //var x = DataBase.DataBaseOpRead<Curso>(DataBase.MapCurso, Query.QuerySelectCurso);
            //int indice = x.IndexOf(cursoSeleccionado);
            //x[indice] = cursoSeleccionado;
            //dgCursos.DataSource = x;

        }

        private void cbTurnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string turno = cbTurnos.SelectedItem.ToString();
            LogicaForm.CargarDataGridViewCursos(dgCursos, $"WHERE TURNO = '{turno}'");
            
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            LogicaForm.CargarDataGridViewCursos(dgCursos);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgCursoInscripto.SelectedRows.Count > 0) 
            {
                var numero = cursosInscriptos.Count();
                Curso cursoSeleccionado = (Curso)dgCursoInscripto.CurrentRow.DataBoundItem;
                cursosInscriptos.Remove(cursoSeleccionado);
                alumnoLogueado.DesuscribirMaterias(alumnoLogueado.Legajo, cursoSeleccionado.CodigoCurso);
                cursoSeleccionado.CantidadAlumnos += 1;
                cursoSeleccionado.CantidadInscriptos -= 1;
                DataBase.ModificarCurso(cursoSeleccionado, cursoSeleccionado.CodigoCurso);
                dgCursos.Refresh();
                var numero2 = cursosInscriptos.Count();
            }

        }
    }
}
