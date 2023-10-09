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
    public partial class FormPagoAlumnos : Form
    {
        public FormPagoAlumnos()
        {
            InitializeComponent();
            
        }

        public Alumno alumnoLogueado { get; set; }

        private void FormPagoAlumnos_Load(object sender, EventArgs e)
        {
            dGridPagos.Rows.Clear();
            CargaEncabezadoDataGrid();
            CargarListDataGrid();
            double aux = alumnoLogueado.PagosCursada.GastosAdministrativos;

        }

        private void CargarListDataGrid() 
        {
            for (int i = 0; i < alumnoLogueado.PagosCursada.cuotasMeses.Count; i++)
            {
                CargaFilasDataGrid(i + 1, alumnoLogueado.PagosCursada.cuotasMeses[i], alumnoLogueado.PagosCursada.GastosAdministrativos, alumnoLogueado.PagosCursada.GastosExtraEstudios);
            }
        }

        private void CargaEncabezadoDataGrid() 
        {
            dGridPagos.Columns.Add("CUOTA", "CUOTA");
            dGridPagos.Columns.Add("MONTO", "MONTO");
            dGridPagos.Columns.Add("GAST.ADMIN", "GAST.ADMIN");
            dGridPagos.Columns.Add("GAST.MAT.ESTUDIOS", "GAST.MAT.ESTUDIOS");
            dGridPagos.Columns.Add("ESTADO", "ESTADO");

            foreach (DataGridViewColumn column in dGridPagos.Columns)
            {
                column.Resizable = DataGridViewTriState.False;
            }
        }

        private void CargaFilasDataGrid(int nroCuota,double cuota, double gastosAdm, double gastoEstudios) 
        {
            string estadoCuenta = EstadoDeCuota(cuota);
            dGridPagos.Rows.Add(nroCuota, cuota, cuota*gastosAdm, cuota*gastoEstudios, estadoCuenta);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lastIndex = alumnoLogueado.PagosCursada.cuotasMeses.Count;
            //dGridPagos.Rows.RemoveAt(lastIndex);
        }
        private string EstadoDeCuota(double cuota)
        {
            string estado = "IMPAGA";
            if (cuota == 0) 
            {
                estado = "PAGA";
            }
            return estado;
        }

        private void dGridPagos_SelectionChanged(object sender, EventArgs e)
        {
            if (dGridPagos.SelectedRows.Count > 0)
            {
                int indiceFilaSeleccionada = dGridPagos.SelectedRows[0].Index;

                double monto = Convert.ToDouble(dGridPagos.Rows[indiceFilaSeleccionada].Cells["MONTO"].Value);
                double gastoAdm = Convert.ToDouble(dGridPagos.Rows[indiceFilaSeleccionada].Cells["GAST.ADMIN"].Value);
                double gastoEscolar = Convert.ToDouble(dGridPagos.Rows[indiceFilaSeleccionada].Cells["GAST.MAT.ESTUDIOS"].Value);

                double total = monto + gastoAdm + gastoEscolar;
                if (total == 0)
                {
                    btnPagar.Enabled = false;
                }
                else 
                {
                    btnPagar.Enabled = true;
                }
                textBox1.Text = $"${total}";

            }

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            FormPagoCuota formularioPagoCuota = new FormPagoCuota();
            formularioPagoCuota.alumnoLogueado = alumnoLogueado;
            this.Close();
            formularioPagoCuota.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.formularioAlumno.Show();
        }
    }
}
