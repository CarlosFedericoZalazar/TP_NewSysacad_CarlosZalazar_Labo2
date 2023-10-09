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
        public FormAdminCursos()
        {
            InitializeComponent();
            this.Activated += FormAdminCursos_Activated;
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

            if (listBoxCursos.SelectedIndex != -1)
            {
                FormEditCurso formularioEditorCurso = new FormEditCurso();
                formularioEditorCurso.infoCurso = (Curso)listBoxCursos.SelectedItem;
                formularioEditorCurso.admnistradorLogueado = admnistradorLogueado;
                formularioEditorCurso.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Curso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.formularioAdministrador.Show();
        }

        private void btnDeleteCurso_Click(object sender, EventArgs e)
        {

            if (listBoxCursos.SelectedIndex != -1)
            {

                Curso cursoBorrar = (Curso)listBoxCursos.SelectedItem;
                DialogResult resultado = MessageBox.Show("¿Desea eliminar curso seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    admnistradorLogueado.EliminarCurso(cursoBorrar);
                    CargaCursosEnLista();

                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Curso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FormAdminCursos_Activated(object sender, EventArgs e)
        {
            CargaCursosEnLista();
        }

        private void CargaCursosEnLista() 
        {            
            LogicaDeFormulario.ActualizarContenidoListBoxes(listBoxCursos);
        }
    }
}
