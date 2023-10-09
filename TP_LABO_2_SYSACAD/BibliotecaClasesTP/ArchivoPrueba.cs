using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesTP
{
    public class ArchivoPrueba
    {
        
        public List<Alumno> listaAlumnos = new List<Alumno>();
        public static List<Administrador> LeerArchivoAdministrador()
        {
            //
            //SIMILUMAMOS LA MAGIA QUE BUSCA EN EL ARCHIVO 
            //
            List<Administrador> listaAdministrador = new List<Administrador>();
            //Administrador admin_1 = new Administrador("Martin", "Vazquez","30527881", "114005","1234","","carlos-zalazar@hotmail.com", "1144076352");
            //Administrador admin_2 = new Administrador("Mariano", "Olivan", "30456881", "114005", "1234", "", "char.elterco@gmail.com", "1144076352");
            //listaAdministrador.Add(admin_1);
            
            //listaAdministrador.Add(admin_2);

            return listaAdministrador;
        }

    }
}