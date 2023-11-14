using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesTP
{
    public class Pagos
    {
        private  double _montoCuota;
        private int _cantidadCuotasMeses;
        private  double _gastosAdministrativos = 0.1; // % CARGOS ADMNISTRATIVOS
        private double _gastosExtrasEstudios = 0.05; // % CARGOS ADMNISTRATIVOS
        private double _porcentajeIncremento;

        public Pagos()
        {
            // TODO: CARGAR LOS VALORES DESDE UN ARCHIVO CONFIG
            _montoCuota = 23000;
            _cantidadCuotasMeses = 5;
            _gastosAdministrativos = 10;
            _gastosExtrasEstudios = 0.5;
            _porcentajeIncremento = 0.3;
        }

        public double MontoCuota { get=>_montoCuota; set=>_montoCuota= value; }
        public int CantidadCuotas { get=>_cantidadCuotasMeses; set=>_cantidadCuotasMeses = value; }
        public  double GastosAdministrativos { get => _gastosAdministrativos; set => _gastosAdministrativos = value; }
        public  double GastosExtraEstudios { get => _gastosExtrasEstudios; set => _gastosExtrasEstudios = value; }

        public void CargarPagos(int legajo) 
        {
            double monto = 2000;
            for (int i = 1; i <= CantidadCuotas; i++) 
            {
                DataBase.DataBaseOpGuardarCuota(legajo, i, CalcularCuota());
                monto += monto * 0.03;
            }
        }

        private double CalcularCuota() 
        {
            double gastosAdmin = (MontoCuota * GastosAdministrativos) / 100;
            double gastoExtraEstudios = (MontoCuota * GastosExtraEstudios) / 100;
            return MontoCuota + gastosAdmin + gastoExtraEstudios;
        }

        private List<double> CargarCuotasPagos() 
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
