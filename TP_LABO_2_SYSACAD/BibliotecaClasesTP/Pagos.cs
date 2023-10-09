using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesTP
{
    public class Pagos
    {
        public List<double> cuotasMeses;
        private double _gastosAdministrativos = 0.1; // % CARGOS ADMNISTRATIVOS
        private double _gastosExtrasEstudios = 0.05; // % CARGOS ADMNISTRATIVOS

        public Pagos() 
        {
            cuotasMeses = CargarCuotasPagos();
        }

        public double GastosAdministrativos { get => _gastosAdministrativos; }
        public double GastosExtraEstudios { get => _gastosExtrasEstudios; }

        private static List<double> CargarCuotasPagos() 
        {
            List<double> MontoMeses = new List<double>();
            MontoMeses.Add(0);
            MontoMeses.Add(18500);
            MontoMeses.Add(18000);
            MontoMeses.Add(18000);
            MontoMeses.Add(21000);
            MontoMeses.Add(23000);           

            return MontoMeses;
        }

        //public double GastosAdmnistrativos { get=>_gastosAdministrativos; set=>_gastosAdministrativos=value; }
    }
}
