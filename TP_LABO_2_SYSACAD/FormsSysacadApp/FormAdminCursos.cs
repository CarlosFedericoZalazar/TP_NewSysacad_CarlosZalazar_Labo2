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
    public partial class FormAdminCursos : Form
    {
        private FormAdmin _formularioAdministrador;
        public FormAdminCursos(FormAdmin formularioAdministrador)
        {
            InitializeComponent();
            _formularioAdministrador = formularioAdministrador;
        }

        public Administrador admnistradorLogueado { get; set; }

        private void btnAddCurso_Click(object sender, EventArgs e)
        {
            FormAddCurso formularioAddCurso = new FormAddCurso();
            formularioAddCurso.admnistradorLogueado = admnistradorLogueado;
            formularioAddCurso.ShowDialog();
        }

        private void FormAdminCursos_Load(object sender, EventArgs e)
        {
            LogicaForm.CargarDataGridViewCursos(dgCursos);
            lblAdminLoged.Text = $"Admin: {admnistradorLogueado.Apellido}, {admnistradorLogueado.Nombre}";
        }

        private void btnEditarCurso_Click(object sender, EventArgs e)
        {
            if (dgCursos.SelectedRows.Count > 0)
            {
                FormEditCurso formularioEditorCurso = new FormEditCurso();
                Curso cursoSeleccionado = (Curso)dgCursos.CurrentRow.DataBoundItem;
                Console.WriteLine(cursoSeleccionado.DiasCursada);
                formularioEditorCurso.infoCurso = cursoSeleccionado;
                formularioEditorCurso.admnistradorLogueado = admnistradorLogueado;
                formularioEditorCurso.ShowDialog();
            }        
            else
            {
                MessageBox.Show("Debe seleccionar un Curso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDeleteCurso_Click(object sender, EventArgs e)
        {
            if (dgCursos.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Desea eliminar curso seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    Curso cursoSeleccionado = (Curso)dgCursos.CurrentRow.DataBoundItem;
                    DataBase.DataBaseOpDelete<Curso>("CURSOS", "ID_CURSO", cursoSeleccionado.CodigoCurso);
                    LogicaForm.CargarDataGridViewCursos(dgCursos);
                }                
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            _formularioAdministrador.Show();
            this.Close();
        }

        private void FormAdminCursos_Activated(object sender, EventArgs e)
        {
            //CargaCursosEnLista();
        }

        private void CargaCursosEnLista() 
        {   
            LogicaForm.CargarDataGridViewCursos(dgCursos);
        }


        private void CargarDataGridViewCursos() 
        {
            dgCursos.DataSource = DataBase.DataBaseOpRead<Curso>(DataBase.MapCurso, Query.QuerySelectCurso);
            dgCursos.Refresh();

            foreach (DataGridViewColumn column in dgCursos.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }

            foreach (int columnIndex in new[] {2, 4, 5, 6, 7 })
            {
                dgCursos.Columns[columnIndex].Visible = false;
            }

        }

        private void dgCursos_Click(object sender, EventArgs e)
        {
            Curso cursoSeleccionado = (Curso)dgCursos.CurrentRow.DataBoundItem;
            txtDescripCurso.Text = cursoSeleccionado.Descripcion;
        }
    }
}
