using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace BibliotecaClasesTP
{
    public class CRUD
    {
        public static void WriteJson(string file, List<Alumno> alumnos)
        {
            string path = Combine(file);
            using (var writer = new StreamWriter(path)) //Combine(file))) 
            {
                var option = new JsonSerializerOptions();
                option.WriteIndented = true;

                var json = JsonSerializer.Serialize(alumnos,option);
                writer.Write(json);
            }
        }


        public static void WriteJson(string file, List<Curso> cursos)
        {
            string path = Combine(file);
            using (var writer = new StreamWriter(path)) //Combine(file))) 
            {
                var option = new JsonSerializerOptions();
                option.WriteIndented = true;

                var json = JsonSerializer.Serialize(cursos, option);
                writer.Write(json);
            }
        }


        public static List<Alumno> ReadJson(string file)
        {
            string path = Combine(file);
            List<Alumno> alumnos = new List<Alumno>();

            if (File.Exists(path))
            {
                using (var reader = new StreamReader(path))
                {                   
                    
                    var json = reader.ReadToEnd();

                    var listaAux = JsonSerializer.Deserialize<List<Alumno>>(json);

                    if (listaAux != null)
                    {
                        alumnos = listaAux;
                    }
                }
            }
            return alumnos;
        }

        

        public static List<Curso> ReadJsonCursos(string file)
        {
            string path = Combine(file);
            List<Curso> listaCursos = new List<Curso>();

            if (File.Exists(path))
            {
                using (var reader = new StreamReader(path))
                {
                    var json = reader.ReadToEnd();

                    var listaAux = JsonSerializer.Deserialize<List<Curso>>(json);

                    if (listaAux != null)
                    {
                        listaCursos = listaAux;
                    }
                }
            }
            return listaCursos;
        }

        public static void ModificarCurso(Curso curso, Curso cursoModificado) 
        {
            var listaCursos = CRUD.ReadJsonCursos("lista_cursos.json");
            
            int indice = listaCursos.IndexOf(curso);
            curso = cursoModificado;

            listaCursos[indice] = curso;
            WriteJson("lista_cursos.json", listaCursos);
        }

        public static void EliminarCurso(Curso cursoDelete)
        {
            var listaCursos = CRUD.ReadJsonCursos("lista_cursos.json");
            listaCursos.Remove(cursoDelete);
            WriteJson("lista_cursos.json", listaCursos);
        }

        public static List<Administrador> ReadJsonAdministrador(string file)
        {
            string path = Combine(file);
            List<Administrador> administrador = new List<Administrador>();

            if (File.Exists(path))
            {
                using (var reader = new StreamReader(path))
                {
                    var json = reader.ReadToEnd();

                    var listaAux = JsonSerializer.Deserialize<List<Administrador>>(json);

                    if (listaAux != null)
                    {
                        administrador = listaAux;
                    }
                }
            }
            return administrador;
        }

        public static string Combine(string path1) // volver a cambia a private!
        {
            Environment.SpecialFolder escritorio = Environment.SpecialFolder.DesktopDirectory;
            var desktop = Environment.GetFolderPath(escritorio);
            var path = Path.Combine(desktop, "documentos", path1);

            return path;
        }

        public static void AltaAlumno(Alumno estudiante) 
        {
            var listaAlumnos = new List<Alumno>();

            try
            {
                listaAlumnos = CRUD.ReadJson("ElementosAlumnos.json");
            }
            catch (FileNotFoundException ex)
            {                
                Console.WriteLine($"Error: {ex.Message}");
                
                // Puedes realizar otras acciones de manejo de excepciones aquí si es necesario
            }
            estudiante.Legajo= estudiante.AsignarLegajo(listaAlumnos.Count() + 1);

            listaAlumnos.Add(estudiante);
            CRUD.WriteJson("ElementosAlumnos.json", listaAlumnos);
        }

        public static void ModificarAlumno(Alumno alumno, Alumno alumnoModificado)
        {
            var listaAlumnos = CRUD.ReadJson("ElementosAlumnos.json");

            int indice = listaAlumnos.IndexOf(alumno);
            alumno = alumnoModificado;

            listaAlumnos[indice] = alumno;
            WriteJson("ElementosAlumnos.json", listaAlumnos);
        }
    }
}
