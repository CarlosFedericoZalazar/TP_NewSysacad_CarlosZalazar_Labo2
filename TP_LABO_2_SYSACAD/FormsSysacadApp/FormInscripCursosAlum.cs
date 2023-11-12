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
        //List<string> cursosInscriptoAlumno = new List<string>();
        List<Curso> listaCursos = GestorDeClases.ExtraerListaCursos();
        
        BindingList<Curso> cursosInscriptos = new BindingList<Curso>();


        FormAlumno _formularioAlumno;
        public FormInscripCursosAlum(FormAlumno formularioAlumno)
        {
            InitializeComponent();
            cbTurnos.SelectedIndex = 0;
            //btnInscribirse.Enabled = false;
            _formularioAlumno = formularioAlumno;
            dgCursoInscripto.DataSource = cursosInscriptos;
            cbTurnos.DataSource = Enum.GetValues(typeof(Horarios.Turno));
        }

        public Alumno alumnoLogueado { get; set; }

        private void FormInscripCursosAlum_Load(object sender, EventArgs e)
        {
            LogicaForm.CargarDataGridViewCursos(dgCursos);
            cursosInscriptos = alumnoLogueado.RecuperarInscripcionMaterias(alumnoLogueado.Legajo);
            dgCursoInscripto.DataSource = cursosInscriptos;

            dgCursos.Columns[7].Visible = true;

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
                MessageBox.Show("EL REGISTRO YA EXISTE");
            }
            else
            {
                cursosInscriptos.Add(cursoSeleccionado);
            }
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {

            alumnoLogueado.InscripcionMaterias(cursosInscriptos,alumnoLogueado.Legajo);
            //bool todoOk = GestorDeClases.ModificarCursosAlumno(alumnoLogueado, cursosInscriptoAlumno);
            //if (todoOk)
            //{
            //    MessageBox.Show("Se han Inscripto correctamente los Cursos Indicados");
            //}
            //this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: RECUPERAR LISTA DE CURSOS INSCRIPTOS.
            
            
            dgCursoInscripto.DataSource = alumnoLogueado.RecuperarInscripcionMaterias(alumnoLogueado.Legajo);

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
                var numero2 = cursosInscriptos.Count();
            }

        }
    }
}
