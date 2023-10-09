using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesTP
{
    public class ClaseMaestra
    {
        public List<Curso> Cursos { get; set; }

        public List<Alumno> Estudiantes { get; set; }

        public List<Administrador> Administradores { get; set; }

        public ClaseMaestra()
        {            
            Cursos = new List<Curso>();
            Estudiantes = new List<Alumno>();
            Administradores = new List<Administrador>();
        }

    }
}
