using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesTP
{
    public static class GestorDeClases
    {
        public static List<Curso> ExtraerListaCursos() => Datos.Abrir().Cursos;
        public static List<Alumno> ExtraerListaEstudiantes() => Datos.Abrir().Estudiantes;

        public static bool ModificarCursosAlumno(Alumno alumnoModificar, List<string> cursosInscriptos) 
        {
            bool saveOk=false;
            try
            {
                int indice = -1;
                ClaseMaestra archivo = Datos.Abrir();
                var listaEstudiantes = archivo.Estudiantes;

                foreach (var item in listaEstudiantes)
                {
                    if (item.Dni == alumnoModificar.Dni)
                    {
                        indice = listaEstudiantes.IndexOf(item);
                        break;
                    }
                }
                listaEstudiantes[indice].ListaMaterias = cursosInscriptos;
                archivo.Estudiantes = listaEstudiantes;
                Datos.Guardar(archivo);
                saveOk = true;
            }
            catch (Exception)
            {
                saveOk = false;
            }
            return saveOk;
        }


        public static string AccederDatosCursoPorCodigo(string codigo) 
        {
            var cursoAlumno = AccederCursoPorCodigo(codigo);
            string infoCurso = "";
            infoCurso = $"{cursoAlumno.CodigoCurso} {cursoAlumno.NombreCurso}" +
            $" {cursoAlumno.TurnoCursada}";
            return infoCurso;
        }


        public static Curso AccederCursoPorCodigo(string codigo) 
        {
            var listaCursos = ExtraerListaCursos();            
            foreach (Curso itemCurso in listaCursos) 
            {
                if (codigo == itemCurso.CodigoCurso) 
                {
                    return itemCurso;
                    
                }
            }
            return null;
        }

        public static class Hash 
        {
            /// <summary>
            /// GENERA HASH DE UN PASS ENVIADO COMO PARAMETRO
            /// </summary>
            /// <param name="pass">LITERAL A HASHEAR</param>
            /// <returns>RETURN STRING DEL HASH GENERADO</returns>
            public static string GenerarHash(string pass) => BCrypt.Net.BCrypt.EnhancedHashPassword(pass, 8);
            /// <summary>
            /// COMPARA UN PASS LITERAL CON UN HASH
            /// </summary>
            /// <param name="pass">PARAMETRO A EVALUAR</param>
            /// <param name="hash">HASH A COMPARAR CON EL LITERAL</param>
            /// <returns>BOOL, TRUE COINCIDENCIA/FALSE CASO CONTRARIO</returns>
            public static bool ValidarHash(string pass, string hash)=> BCrypt.Net.BCrypt.EnhancedVerify(pass, hash);
            
        }

        public static void EliminarRegistro(Curso cursoDelete)
        {
            ClaseMaestra archivo = Datos.Abrir();
            List<Alumno> listaAlumnos = archivo.Estudiantes;
            archivo.Estudiantes = EliminarRegistro(listaAlumnos, cursoDelete.CodigoCurso);
            archivo.Cursos.Remove(cursoDelete);
            Datos.Guardar(archivo);
        }

        public static List<Alumno> EliminarRegistro(List<Alumno> listaAlumnos, string cursoDelete)
        {
            foreach (Alumno itemAlumno in listaAlumnos)
            {
                foreach (string itemCodigoCurso in itemAlumno.ListaMaterias)
                {
                    if (itemCodigoCurso == cursoDelete)
                    {
                        itemAlumno.ListaMaterias.Remove(itemCodigoCurso);
                        break;
                    }
                }
            }
            return listaAlumnos;
        }

        public static void ModificarRegistroCurso(Curso curso, Curso cursoModificado)
        {
            ClaseMaestra archivo = Datos.Abrir();
            var listaCursos = archivo.Cursos;
            int indice = listaCursos.IndexOf(curso);
            archivo.Cursos[indice] = cursoModificado;
            Datos.Guardar(archivo);
        }

        public static string  GenerarLegajo() 
        {
            ClaseMaestra archivo = Datos.Abrir();
            return archivo.Estudiantes.Count().ToString();
        }

        public static void AltaRegistro(Alumno nuevoRegistro)
        {
            ClaseMaestra listaCursoClaseMaestra = Datos.Abrir();
            listaCursoClaseMaestra.Estudiantes.Add(nuevoRegistro);
            Datos.Guardar(listaCursoClaseMaestra);
        }

        public static void AltaRegistro(Curso nuevoRegistro)
        {
            ClaseMaestra listaCursoClaseMaestra = Datos.Abrir();
            listaCursoClaseMaestra.Cursos.Add(nuevoRegistro);
            Datos.Guardar(listaCursoClaseMaestra);
        }

    }
}
