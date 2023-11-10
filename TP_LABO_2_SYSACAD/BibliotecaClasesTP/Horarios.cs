using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BibliotecaClasesTP
{
    public static class Horarios
    {
        public enum Turno
        {
            MAÑANA,
            TARDE,
            NOCHE
        }
        public enum Dias
        {
            LUNES,
            MARTES,
            MIERCOLES,
            JUEVES,
            VIERNES
        }
        public static  List<string> CargaHorario(string turno) 
        {          

            List<string> lista = new List<string>();
            switch (turno)
            {
                case "MAÑANA":
                    List<string> itemsManiana = new List<string>
                    {
                        "08:30 AM/10:30 AM",
                        "11:00 AM/13:00 PM",
                        "08:30 AM/13:00 PM"
                    };
                    lista.AddRange(itemsManiana);
                    break;
                case "TARDE":
                    List<string> itemsTarde = new List<string>
                    {
                        "13:30 PM/15:30 PM",
                        "16:00 PM/18:00 PM",
                        "13:30 PM/18:00 PM",
                    };
                    lista.AddRange(itemsTarde);
                    break;
                case "NOCHE":
                    List<string> itemsNoche = new List<string>
                    {
                        "18:30/20:30",
                        "21:00/22:30",
                        "18:30/22:30"
                    };
                    lista.AddRange(itemsNoche);
                    break;
            }
            return lista;
        }

    }
}
