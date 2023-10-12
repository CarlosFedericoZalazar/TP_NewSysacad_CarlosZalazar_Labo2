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
    public class LogicaDeFormulario
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
            switch (turno)
            {
                case "MAÑANA":
                    listBoxHorarios.Items.Add("08:30/10:30");
                    listBoxHorarios.Items.Add("11:00/13:00");
                    listBoxHorarios.Items.Add("08:30/13:00");
                    break;
                case "TARDE":
                    listBoxHorarios.Items.Add("13:30/15:30");
                    listBoxHorarios.Items.Add("16:00/18:00");
                    listBoxHorarios.Items.Add("13:30/18:00");
                    break;
                case "NOCHE":
                    listBoxHorarios.Items.Add("18:30/20:30");
                    listBoxHorarios.Items.Add("21:00/22:30");
                    listBoxHorarios.Items.Add("18:30/22:30");
                    break;
            }

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

        public static bool ValidarDni(TextBox txtDni) 
        {
            if (Validador.ValidarFormatoDni(txtDni.Text) && txtDni.Text != "") 
            {
                return true;
            }
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
            //cajaTexto.Focus();
        }

    }
}
