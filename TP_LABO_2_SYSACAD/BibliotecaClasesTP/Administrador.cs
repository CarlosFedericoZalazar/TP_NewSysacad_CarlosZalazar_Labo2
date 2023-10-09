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


        public void AltaRegistro(Curso nuevoRegistro) 
        {
            ClaseMaestra listaCursoClaseMaestra = Datos.Abrir();
            listaCursoClaseMaestra.Cursos.Add(nuevoRegistro);
            Datos.Guardar(listaCursoClaseMaestra);
        }

        public void AltaRegistro(Alumno nuevoRegistro)
        {
            ClaseMaestra listaCursoClaseMaestra = Datos.Abrir();
            listaCursoClaseMaestra.Estudiantes.Add(nuevoRegistro);
            Datos.Guardar(listaCursoClaseMaestra);
        }

        public void EliminarCurso(Curso cursoDelete)
        {
            GestorDeClases.EliminarRegistro(cursoDelete);
        }
            


        public void ModificarRegistro(Curso curso, Curso cursoModificado) 
        {
            ClaseMaestra archivo = Datos.Abrir();
            var listaCursos = archivo.Cursos;
            int indice = listaCursos.IndexOf(curso);
            archivo.Cursos[indice] = cursoModificado;
            Datos.Guardar(archivo);
        }

        public string AsignarLegajoAlumno() 
        {
            ClaseMaestra archivo = Datos.Abrir();
            return archivo.Estudiantes.Count().ToString();
        }

    }
}