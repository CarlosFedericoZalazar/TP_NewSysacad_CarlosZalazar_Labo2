using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesTP
{
    public class Administrador
    {
        string _nombre;
        string _apellido;
        string _legajo;
        string _password;
        public Administrador(string nombre, string apellido, string legajo, string password)
        {
            _nombre = nombre;
            _apellido = apellido;
            _legajo = legajo;
            _password = password;
        }

        public string Nombre { get=>_nombre; set=>_nombre=value; }

        public string Apellido { get=>_apellido; set => _apellido = value; }

        public string Password { get=>_password; set => _password = value; }
        public string Legajo { get=> $"{_legajo}" ; set => _legajo = value; }

        public void AltaCurso(Curso nuevoRegistro)
        {
            // LOGICA PARA AGREGAR A LA BASE DE DATOS
            GestorDeClases.AltaRegistro(nuevoRegistro);
        }

        public void AltaEstudiante(Alumno nuevoRegistro) 
        {
            GestorDeClases.AltaRegistro(nuevoRegistro);
        }

        public void EliminarCurso(Curso cursoDelete)
        {
            GestorDeClases.EliminarRegistro(cursoDelete);
        }

        public void ModificarCurso(Curso curso, Curso cursoModificado) 
        {
            GestorDeClases.ModificarRegistroCurso(curso, cursoModificado);
        }
        public string AsignarLegajoAlumno() => GestorDeClases.GenerarLegajo();

    }
}