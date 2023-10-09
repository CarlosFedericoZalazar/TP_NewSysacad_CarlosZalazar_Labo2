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
    public partial class FormPagoCuota : Form
    {

        public FormPagoCuota()
        {
            InitializeComponent();
           
        }

        public Alumno alumnoLogueado { get; set; }

        private void FormPagoCuota_Load(object sender, EventArgs e)
        {
            label4.Text = "AVISARM AL MAIL INDICADO EL PAGO\n DE LA CUOTA";
        }
    }
}
