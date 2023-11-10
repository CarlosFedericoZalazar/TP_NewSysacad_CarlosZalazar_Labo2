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
        List<string> cursosInscriptoAlumno = new List<string>();
        List<Curso> listaCursos = GestorDeClases.ExtraerListaCursos();

        
        BindingList<Curso> cursosInscriptos = new BindingList<Curso>();


        FormAlumno _formularioAlumno;
        public FormInscripCursosAlum(FormAlumno formularioAlumno)
        {
            InitializeComponent();
            cbTurnos.SelectedIndex = 0;
            btnInscribirse.Enabled = false;
            _formularioAlumno = formularioAlumno;
            dgCursoInscripto.DataSource = cursosInscriptos;
        }

        public Alumno alumnoLogueado { get; set; }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listMaterias.Enabled = true;            
        }

        private void FormInscripCursosAlum_Load(object sender, EventArgs e)
        {
            LogicaForm.CargarDataGridViewCursos(dgCursos);

            dgCursos.Columns[7].Visible = true;

            foreach (int columnIndex in new[] { 2, 3, 4, 5, 6, 7 })
            {
                dgCursoInscripto.Columns[columnIndex].Visible = false;
            }

        }

        private void btnInscribirse_Click(object sender, EventArgs e)
        {
            //var cursoSeleccionado = (Curso)listMaterias.SelectedItem;

            //bool cursoYaInscripto = Validador.ValidarCoincidenciaCodigoCurso(cursosInscriptoAlumno, cursoSeleccionado.CodigoCurso);
            //if (cursoYaInscripto)
            //{
            //    MessageBox.Show("EL REGISTRO YA EXISTE");
            //}
            //else
            //{
            //    //cursosInscriptoAlumno.Add(cursoSeleccionado.CodigoCurso);
            //    CargarListasCursos(listCursosAlumno, cursosInscriptoAlumno);
            //}
        }

        private void listMaterias_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            btnInscribirse.Enabled = true;
            //Curso cursoSeleccioando = (Curso)listMaterias.SelectedItem;
            //txtDescripcion.Text = cursoSeleccioando.Descripcion;
        }

        private void CargarListasCursos(ListBox cajaList, List<Curso>listaCursos)
        {
            LogicaForm.ActualizarContenidoListBoxes(cajaList, cbTurnos.SelectedItem.ToString());
        }

        private void CargarListasCursos(ListBox cajaList, List<string> cursosInscriptoAlumno)
        {
            cajaList.Items.Clear();
            foreach (string itemCodMateria in cursosInscriptoAlumno) 
            {
                string infoCodigoCurso = GestorDeClases.AccederDatosCursoPorCodigo(itemCodMateria);
                cajaList.Items.Add(infoCodigoCurso);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool todoOk = GestorDeClases.ModificarCursosAlumno(alumnoLogueado, cursosInscriptoAlumno);
            if (todoOk)
            {
                MessageBox.Show("Se han Inscripto correctamente los Cursos Indicados");
            }
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgCursos.SelectedRows.Count > 0)
            {
                Curso cursoSeleccionado = (Curso)dgCursos.CurrentRow.DataBoundItem;
                //Curso prueba = new Curso("C8A8","Matematica","sumas",2,"TARDE","LUNEAS","");
                cursosInscriptos.Add(cursoSeleccionado);
            }
        }
    }
}
