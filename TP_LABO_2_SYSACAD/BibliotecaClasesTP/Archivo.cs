using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;


namespace BibliotecaClasesTP
{
    public static class Archivo

    {
        private static string _directorio = DirectorioArchivo();

        /// <summary>
        /// Se encarga de abrir un archivo json y deserializar la info dentro del json
        /// </summary>
        /// <returns>Devuelve un objeto de la ClaseMaestra</returns>
        public static ClaseMaestra Abrir()
        {
            ClaseMaestra listaDatos = new ClaseMaestra();
            try
            {
                string path = $"{_directorio}\\materias-1.json";
                using var sr = new StreamReader($"{_directorio}\\materias-1.json");
                using (var reader = new StreamReader(path))
                {
                    var json = reader.ReadToEnd();
                    var datos = JsonSerializer.Deserialize<ClaseMaestra>(json);
                    if (datos != null)
                    {
                        listaDatos = datos;
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Excepción capturada: " + ex.Message);
            }
            return listaDatos;
        }

        public static void Guardar(ClaseMaestra datos)
        {            
            string path = $"{_directorio}\\materias-1.json";
            using (var writer = new StreamWriter(path)) //Combine(file))) 
            {
                var option = new JsonSerializerOptions();
                option.WriteIndented = true;
                var json = JsonSerializer.Serialize(datos, option);
                writer.Write(json);
            }
        }


        //------------------------------------------------------------------------------

        public static T Abrir<T>(string fileName)
        {
            T listaDatos = default(T);
            try
            {
                string path = $"{_directorio}/{fileName}.json";
                using var sr = new StreamReader($"{_directorio}/{fileName}.json");
                using (var reader = new StreamReader(path))
                {
                    var json = reader.ReadToEnd();
                    var datos = JsonSerializer.Deserialize<T>(json);
                    if (datos != null)
                    {
                        listaDatos = datos;                        
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Excepción capturada: " + ex.Message);
            }
            return listaDatos;
        }

        public static void Guardar<T>(T item, string fileName)
        {
            string path = $"{_directorio}\\{fileName}.json";
            using (var writer = new StreamWriter(path)) //Combine(file))) 
            {
                var option = new JsonSerializerOptions();
                option.WriteIndented = true;
                var json = JsonSerializer.Serialize(item, option);
                writer.Write(json);
            }
        }

        public static string DirectorioArchivo() // volver a cambia a private!
        {
            //string misDocumentosPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Environment.SpecialFolder escritorio = Environment.SpecialFolder.DesktopDirectory;
            var desktop = Environment.GetFolderPath(escritorio);
            var path = Path.Combine(desktop, "archivos sysa");
            return path;
        }

    }
}
