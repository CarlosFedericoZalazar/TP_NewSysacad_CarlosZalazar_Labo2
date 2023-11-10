using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesTP
{
    public class Curso
    {
        private int _cantidadAlumnos;
        private string _nombreCurso;
        private string _codigoCurso;
        private string _descripcion;
        private string _diasCursada = "";
        private string _turno = "";
        private string _horario = "";
        private int cantidadInscriptos = 0;
        public int topeCantidadAlumnos = 50;


        public Curso(string codigoCurso, string nombreCurso, string descripcion, int cantidadAlumnos)
        {
            _codigoCurso = codigoCurso;
            _nombreCurso = nombreCurso;
            _descripcion = descripcion;
            _cantidadAlumnos = cantidadAlumnos;
        }

        // HACER CONSTRUCTOR PARA TOMAR TODOS LOS DATOS DE LA BASE DE DATOS

        public Curso(string codigoCurso, string nombreCurso, string descripcion, int cantidadAlumnos, string turno, string diasCursada, string horario) :this(codigoCurso,nombreCurso,descripcion,cantidadAlumnos)
        {
            _turno = turno;
            _diasCursada = diasCursada;
            _horario = horario;
        }


        public override string ToString()
        {
            return $"{NombreCurso} / {CodigoCurso} / {_turno}";
        }
        public string CodigoCurso { get=>_codigoCurso; set => _codigoCurso=value; }

        public string NombreCurso { get => _nombreCurso; set => _nombreCurso = value; }

        public string Descripcion { get => _descripcion; set=> _descripcion = value; }
        public int CantidadAlumnos { get=> _cantidadAlumnos; set=> _cantidadAlumnos = value; }
        public string  DiasCursada { get=> _diasCursada; set=> _diasCursada=value; }

        public string TurnoCursada { get=>_turno; set=>_turno=value; }

        public string HorarioCursada { get=>_horario; set=>_horario=value; }

        public int CantidadInscriptos { get=>cantidadInscriptos; set=> cantidadInscriptos=value; }
        public static bool operator ==(Curso cursoUno, Curso cursoDos)
        {

            if (cursoUno.CodigoCurso == cursoDos.CodigoCurso || cursoUno.NombreCurso == cursoDos.NombreCurso)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Curso cursoUno, Curso cursoDos)
        {
            return (cursoUno == cursoDos);// || cursoUno.NombreCurso == cursoDos.NombreCurso);
        }

        public override int GetHashCode()
        {
            return CodigoCurso.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Curso other = (Curso)obj;
            return CodigoCurso == other.CodigoCurso || NombreCurso == other.NombreCurso; ;
        }

    }

}
