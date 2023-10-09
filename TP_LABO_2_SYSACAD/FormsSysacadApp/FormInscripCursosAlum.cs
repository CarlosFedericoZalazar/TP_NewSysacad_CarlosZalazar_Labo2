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

        public FormInscripCursosAlum()
        {
            InitializeComponent();
            cbTurnos.SelectedIndex = 0;
            btnInscribirse.Enabled = false;
        }

        public Alumno alumnoLogueado { get; set; }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LogicaDeFormulario.ActualizarContenidoListBoxes(listMaterias, cbTurnos.SelectedItem.ToString());
            listMaterias.Enabled = true;            
        }

        private void FormInscripCursosAlum_Load(object sender, EventArgs e)
        {
            cursosInscriptoAlumno = alumnoLogueado.ListaMaterias;            
            if (listaCursos.Count() == 0) 
            {
                MessageBox.Show("No hay Cursos Disponibles", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            CargarListasCursos(listCursosAlumno, cursosInscriptoAlumno);

            CargarListasCursos(listMaterias, listaCursos);

            cbTurnos.SelectedIndex = 0;
            listMaterias.Enabled = false;
            btnInscribirse.Enabled = false;            
        }

        private void btnInscribirse_Click(object sender, EventArgs e)
        {
            var cursoSeleccionado = (Curso)listMaterias.SelectedItem;

            bool cursoYaInscripto = Validador.ValidarCoincidenciaCodigoCurso(cursosInscriptoAlumno, cursoSeleccionado.CodigoCurso);
            if (cursoYaInscripto)
            {
                MessageBox.Show("EL REGISTRO YA EXISTE");
            }
            else
            {
                cursosInscriptoAlumno.Add(cursoSeleccionado.CodigoCurso);
                CargarListasCursos(listCursosAlumno, cursosInscriptoAlumno);
            }
        }

        private void listMaterias_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            btnInscribirse.Enabled = true;
            Curso cursoSeleccioando = (Curso)listMaterias.SelectedItem;
            txtDescripcion.Text = cursoSeleccioando.Descripcion;
        }

        private void CargarListasCursos(ListBox cajaList, List<Curso>listaCursos)
        {
            LogicaDeFormulario.ActualizarContenidoListBoxes(cajaList, cbTurnos.SelectedItem.ToString());
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
    }
}
