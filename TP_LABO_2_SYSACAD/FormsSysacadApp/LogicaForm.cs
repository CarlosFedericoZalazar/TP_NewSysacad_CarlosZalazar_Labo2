using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing; // para usar point
using BibliotecaClasesTP;
using System.Collections;


namespace FormsSysacadApp
{
    public class LogicaForm
    {
        public static void ComportamientoCajaDeTexto(bool esValido, TextBox cajaDeTexto, Label lblError)
        {

            if (!esValido)
            {
                int newY = cajaDeTexto.Bottom + 5; // Ajusta la distancia vertical como desees

                // Establece la nueva ubicación del Label
                lblError.Location = new Point(cajaDeTexto.Left, newY);

                lblError.Visible = true;
                cajaDeTexto.Focus();
                cajaDeTexto.SelectAll();
            }
            else 
            {
                lblError.Visible = false;
            }

        }

        public static void SeleccionHorarioPorTurno(String turno, ListBox listBoxHorarios)
        {
            List<string> listaHarario = Horarios.CargaHorario(turno);
            listBoxHorarios.Items.AddRange(listaHarario.ToArray());
        }


        public static void ActualizarContenidoListBoxes(ListBox listActualizar, string filter = null, bool sort = true)
        {
            var listaCursos = GestorDeClases.ExtraerListaCursos();

            //ORDENAMOS LA LISTBOX
            if (sort) 
            {
                listaCursos.Sort((a, b) => a.CodigoCurso.CompareTo(b.CodigoCurso));
            }            
            listActualizar.Items.Clear();

            foreach (var curso in listaCursos)
            {
                if (curso.TurnoCursada == filter || filter == null) 
                {
                    listActualizar.Items.Add(curso);
                }                
            }
        }
        
        public static void CargarDataGridViewCursos(DataGridView dgCursos)
        {
            dgCursos.DataSource = DataBase.DataBaseOpRead<Curso>(DataBase.MapCurso, Query.QuerySelectCurso);
            dgCursos.Refresh();

            foreach (DataGridViewColumn column in dgCursos.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            foreach (int columnIndex in new[] { 2, 4, 5, 6, 7 })
            {
                dgCursos.Columns[columnIndex].Visible = false;
            }

            // Supongamos que quieres cambiar el nombre de la primera columna.
            int col = 0; // El índice de la columna que deseas cambiar.
            string nuevoNombre = "Id"; // El nuevo nombre que deseas asignar.

            // Cambia el nombre de la columna usando la propiedad HeaderText.
            dgCursos.Columns[col].HeaderText = nuevoNombre;



        }




        //------------------------------------------------------------------------------
        public static bool ValidarNombreApellido(List<TextBox> listaNombreApellido, Label labelError) 
        {
            foreach (TextBox itemtxtBox in listaNombreApellido) 
            {
                if (!Validador.ValidarTexto(itemtxtBox.Text) || itemtxtBox.Text=="") 
                {
                    PosicionamientoLabelError(itemtxtBox, labelError);
                    return false;
                }
            }
            return true;
        }

        public static bool ValidarDni(TextBox txtDni, Label labelError) 
        {
            if (Validador.ValidarFormatoDni(txtDni.Text) && txtDni.Text != "") 
            {
                return true;
            }
            PosicionamientoLabelError(txtDni, labelError);
            return false;
        }

        public static bool ValidarTextosVacios(List<TextBox> listaCajaTexto, Label labelError)
        {
            foreach (TextBox itemtxtBox in listaCajaTexto)
            {
                if (itemtxtBox.Text == "")
                {
                    PosicionamientoLabelError(itemtxtBox, labelError);
                    return false;
                }
            }
            return true;
        }

        public static bool ValidarTextoMail(TextBox cajaTexto, Label labelError)
        {
            bool emailOk = false;
            emailOk = Validador.ValidarEmail(cajaTexto.Text);
            if (emailOk) 
            {
                return true;
            }
            PosicionamientoLabelError(cajaTexto, labelError);
            return false;
        }

        public static void PosicionamientoLabelError(TextBox cajaTexto, Label labelError)
        {
            int PosX = cajaTexto.Location.X;
            int PosY = cajaTexto.Location.Y + 25;

            labelError.Location = new System.Drawing.Point(PosX, PosY);
            labelError.Visible = true;
            cajaTexto.Focus();
            cajaTexto.SelectAll();

        }

    }
}
