using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesTP
{  
    public class Alumno : Usuario
    {
        List<string> materias = new List<string>();
        private bool habilitadoCambioPass;
        private Pagos _pagosCursada = new Pagos();
        
        public Alumno(string nombre, string apellido, string dni,string legajo, string password, bool cambioPass, string direccion , string email,string telefono) : base(nombre, apellido, dni, legajo, password, direccion,email, telefono)
        {
            habilitadoCambioPass = cambioPass;
        }

        //public static bool operator ==(Alumno estudianteUno, Alumno estudianteDos)
        //{            
            
        //    if (estudianteUno.Dni == estudianteDos.Dni || estudianteDos==null)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        public List<string> ListaMaterias { get => materias; set => materias=value; }


        public Pagos PagosCursada { get=>_pagosCursada; set=>_pagosCursada = value; }
        public bool CambioPass { get=> habilitadoCambioPass; set=> habilitadoCambioPass=value; }

        //public static bool operator !=(Alumno estudianteUno, Alumno estudianteDos)
        //{
        //    return (estudianteUno == estudianteDos);
        //}

        //public override int GetHashCode()
        //{            
        //    return Dni.GetHashCode();
        //}

        //public override bool Equals(object obj)
        //{
        //    if (obj == null || GetType() != obj.GetType())
        //    {
        //        return false;
        //    }

        //    Alumno other = (Alumno)obj;
        //    return Dni == other.Dni;
        //}
        public string AsignarLegajo(int legajoAlumno) => (legajoAlumno++).ToString();

        public void EnviarCredenciales(Alumno infoAlumno) 
        {
            // LOGICA PARA ENVIAR MAIL AL ESTUDIANTE
        }

        public List<Curso> GetListaCursos() 
        {
            List<Curso> listaCurso = new List<Curso>();

            foreach (string itemCodigo in ListaMaterias) 
            {
                var cursoAlumno = GestorDeClases.AccederCursoPorCodigo(itemCodigo);
                listaCurso.Add(cursoAlumno);
            }
                return listaCurso;
        }
    }

}