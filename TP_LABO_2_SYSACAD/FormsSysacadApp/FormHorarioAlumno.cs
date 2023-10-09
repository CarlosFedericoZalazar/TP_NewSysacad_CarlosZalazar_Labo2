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
    public partial class FormHorarioAlumno : Form
    {
        
        List<Curso> listaCursosAlumno = new List<Curso>();
        
        public FormHorarioAlumno()
        {
            InitializeComponent();

            listView1.ColumnWidthChanging += listView1_ColumnWidthChanging;

            listView1.View = View.Details; // Muestra el ListView en modo de detalles
            listView1.Columns.Add("DIAS", 100); // Agrega una columna con ancho 100
            listView1.Columns.Add("HORARIO", 150); // Agrega otra columna con ancho 150
            listView1.Columns.Add("ASIGNATURA", 100);
            listView1.Columns.Add("COD.CURSO", 100);
            listView1.Columns.Add("AULA", 100);
            //MostrarCursos();
        }
        public Alumno alumnoLogueado { get; set; }

        private void FormHorarioAlumno_Load(object sender, EventArgs e)
        {
            MostrarCursos();

            StringBuilder sbAlumno = new StringBuilder();
            sbAlumno.AppendFormat($"{label1.Text} {alumnoLogueado.Nombre}, {alumnoLogueado.Apellido}");
            label1.Text = sbAlumno.ToString();
        }

        private void listView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void listView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void listView1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void MostrarCursos() 
        {
            listaCursosAlumno = alumnoLogueado.GetListaCursos();

            // MODIFICAR CRITERIO DE ORDENAMIENTO
            listaCursosAlumno.Sort((a, b) => a.DiasCursada.CompareTo(b.DiasCursada));

            foreach (Curso itemCurso in listaCursosAlumno) 
            {
                ListarCursosListView(itemCurso);
            }            
        }

        private void ListarCursosListView(Curso cursoAlumno) 
        {
            ListViewItem item = new ListViewItem($"{cursoAlumno.DiasCursada}");
            item.SubItems.Add($"{cursoAlumno.HorarioCursada}");
            item.SubItems.Add($"{cursoAlumno.NombreCurso}");
            item.SubItems.Add($"{cursoAlumno.CodigoCurso}");
            item.SubItems.Add("Aula: 315");
            listView1.Items.Add(item);
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
                
        }
    }
}
