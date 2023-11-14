using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesTP
{
    public class Config
    {
        public Pagos PagoCuotas { get; set; }

        public Config()
        {
            //PagoCuotas = new Pagos(23000, 5, 10, 0.5, 0.3);
            GenerarCuotas();
        }

        private void GenerarCuotas() 
        {
            Archivo.Guardar(this, "HolaMan");

        }

    }
}
