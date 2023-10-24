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

            foreach (DataGridViewColumn column in dgCursos.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }
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
            CargaCursosEnLista();
            lblAdminLoged.Text = $"Admin: {admnistradorLogueado.Apellido}, {admnistradorLogueado.Nombre}";
        }

        private void btnEditarCurso_Click(object sender, EventArgs e)
        {
            if (dgCursos.SelectedRows.Count > 0)
            {
                FormEditCurso formularioEditorCurso = new FormEditCurso();
                formularioEditorCurso.infoCurso = ItemCursoSeleccionadoDatGrid();
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
                    Curso cursoBorrar = ItemCursoSeleccionadoDatGrid();
                    admnistradorLogueado.EliminarCurso(cursoBorrar);
                    CargaCursosEnLista();
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
            CargaCursosEnLista();
        }

        private void CargaCursosEnLista() 
        {   
            LogicaDeFormulario.ActualizarContenidoDataGridView(dgCursos);
        }


        // EVALUAR SI LO METEMOS EN LA LOGICA DEL FORMULARIO
        private Curso ItemCursoSeleccionadoDatGrid() 
        {
            DataGridViewRow filaSeleccionada = dgCursos.SelectedRows[0];
            string valorCeldaSeleccionada = filaSeleccionada.Cells["Column2"].Value.ToString();
            
            return GestorDeClases.AccederCursoPorCodigo(valorCeldaSeleccionada);
        }
    }
}
