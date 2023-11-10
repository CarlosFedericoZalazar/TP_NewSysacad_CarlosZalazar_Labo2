using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace BibliotecaClasesTP
{
    public class DataBase
    {
        private static SqlConnection conexion;
        private static string cadenaConexion;
        private static SqlCommand comando;

        static DataBase()
        {
            cadenaConexion = @"Server=.\SQLEXPRESS;Database=NEW_SYSACAD_DB;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";
            conexion = new SqlConnection(cadenaConexion);

            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
        }
        
        public static List<T> DataBaseOpRead<T>(Func<IDataRecord, T> mapeo,Func<string>query)
        {
            List<T> lista = new List<T>();
            Console.WriteLine("query");
            try
            {
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }

                comando.CommandText = query();
                //comando.Parameters.AddWithValue("@ algo...") para evitar la inyeccion sql
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        T objeto = mapeo(reader);
                        lista.Add(objeto);
                    }
                }
                return lista;
            }
            catch (Exception)
            {
                throw;
                
            }
            finally
            {
                conexion.Close();
            }
        }

        public static void DataBaseOpDelete<T>(string tabla, string col, string idSeleccionado)
        {
            try
            {
                conexion.Open();
                var query = "DELETE FROM " + tabla + $" WHERE ID_CURSO  = '{idSeleccionado}'";
                comando.CommandText = query;

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        //-------------------------------------------------------------------
        // QUERY ALTA DE REGISTRO CURSO
        public static void DataBaseOpGuardar(Curso curso)
        {
            try
            {
                conexion.Open();

                var query = "INSERT INTO CURSOS (ID_CURSO, NOMBRE, DESCRIPCION, CUPO_ALUMNOS, TURNO, HORARIO, INSCRIPTOS, DIA) " +
                $"VALUES (@id_curso,@_nombre, @descripcion, @cupo_alumnos, @turno, @horario ,@inscriptos, @dia)";

                comando.CommandText = query;

                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@id_curso", curso.CodigoCurso);
                comando.Parameters.AddWithValue("@_nombre", curso.NombreCurso);
                comando.Parameters.AddWithValue("@descripcion", curso.Descripcion);
                comando.Parameters.AddWithValue("@cupo_alumnos", curso.CantidadAlumnos);
                comando.Parameters.AddWithValue("@turno", curso.TurnoCursada);
                comando.Parameters.AddWithValue("@horario", curso.HorarioCursada);                
                comando.Parameters.AddWithValue("@inscriptos", curso.CantidadInscriptos);
                comando.Parameters.AddWithValue("@dia", curso.DiasCursada);
                

                var filasAfectadas = comando.ExecuteNonQuery();
                Console.WriteLine("Filas afectadas" + filasAfectadas);
            }
            catch (Exception)
            {
                //throw;
                conexion.Close();
            }
        }

        //-------------------------------------------------------------------
        // QUERY ALTA DE REGISTRO ALUMNOS
        public static void DataBaseOpGuardar(Alumno alumno)
        {
            try
            {
                conexion.Open();
                // Alumno("0", txtName.Text, txtSurname.Text, txtDocument.Text, "0", stringDireccion, txtEmail.Text, txtPhone.Text, checkChangePass.Checked);
                var query = "INSERT INTO ALUMNOS (NOMBRE, DNI, USUARIO, PASSWORD, DIRECCION, EMAIL, TELEFONO, CHANGEPASS) " +
                $"VALUES (@nombre, @dni, @usuario, @password, @direccion ,@email, @telefono, @cambiopass)";

                string usuario = AsignarUserDB(alumno);

                comando.CommandText = query;               


                comando.Parameters.Clear();

                comando.Parameters.AddWithValue("@nombre", alumno.NombreApellido);
                comando.Parameters.AddWithValue("@dni", alumno.Dni);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@password", alumno.Password);
                comando.Parameters.AddWithValue("@direccion", alumno.Direccion);
                comando.Parameters.AddWithValue("@email", alumno.Email);
                comando.Parameters.AddWithValue("@telefono", alumno.Telefono);
                comando.Parameters.AddWithValue("@cambiopass", alumno.CambioPass ? 1 : 0); ;

                var filasAfectadas = comando.ExecuteNonQuery();
                Console.WriteLine("Filas afectadas" + filasAfectadas);
            }
            catch (Exception)
            {
                //throw;
                conexion.Close();
            }
        }

        private static string AsignarUserDB(Alumno alumno) 
        {
            string palabra1 = alumno.Nombre;
            string palabra2 = alumno.Apellido;

            string UsuarioCreado = $"{palabra1.Substring(0, 1)}{palabra2.Substring(0, 1)}{alumno.Dni}";

            return UsuarioCreado;
        }


        public static void DataBaseOpGuardar(Administrador admnistrador)
        {
            try
            {
                conexion.Open();

                var query = "INSERT INTO ADMINISTRADOR (NOMBRE, APELLIDO, USUARIO, PASSWORD) " +
                $"VALUES (@nombre, @apellido, @usuario, @password)";

                comando.CommandText = query;
                
                comando.Parameters.Clear();
                
                comando.Parameters.AddWithValue("@nombre", admnistrador.Nombre);
                comando.Parameters.AddWithValue("@apellido", admnistrador.Apellido);
                comando.Parameters.AddWithValue("@usuario", admnistrador.Legajo);
                comando.Parameters.AddWithValue("@password", admnistrador.Password);
                var filasAfectadas = comando.ExecuteNonQuery();
                Console.WriteLine("Filas afectadas" + filasAfectadas);
            }
            catch (Exception)
            {
                //throw;
                conexion.Close();
            }
        }


        public static Curso MapCurso(IDataRecord reader)
        {           
            var codigoCurso = reader["ID_CURSO"].ToString();
            var nombre = reader["NOMBRE"].ToString();
            var descripcion = reader["DESCRIPCION"].ToString();
            var cantidadAlumnos = Convert.ToInt32(reader["CUPO_ALUMNOS"]);
            var turno = reader["TURNO"].ToString();
            var dia = reader["DIA"].ToString();
            var horario = reader["HORARIO"].ToString();
            var curso = new Curso(codigoCurso, nombre, descripcion, cantidadAlumnos, turno, dia, horario);
            
            return curso;
        }

        public static void GuardarCurso(Curso curso) 
        {
            var query = $"INSERT INTO CURSOS (ID_CURSO,NOMBRE,DESCRIPCION,CUPO_ALUMNOS,TURNO)" +
                $" VALUES (@id,@nombre,@descripcion,@cupo_alumnos,@turnos)";
            
            comando.CommandText = query;
            
            comando.Parameters.Clear();
            
            comando.Parameters.AddWithValue("@id", curso.CodigoCurso);
            comando.Parameters.AddWithValue("@nombre", curso.NombreCurso);
            comando.Parameters.AddWithValue("@descripcion", curso.Descripcion);
            comando.Parameters.AddWithValue("@cupo_alumnos", curso.CantidadAlumnos);
            comando.Parameters.AddWithValue("@turnos", curso.TurnoCursada);
            //DataBaseOpGuardar(comando);
        }

        public static void ModificarCurso(Curso curso, string codigoAModificar)
        {
            try
            {
                conexion.Open();


                var query = "UPDATE CURSOS SET ID_CURSO = @idCurso, NOMBRE = @nombre, DESCRIPCION = @descripcion, CUPO_ALUMNOS = @cupo_alumnos," +
                        "TURNO = @turno, HORARIO = @horario, INSCRIPTOS = @inscriptos, DIA = @dia WHERE ID_CURSO = @condicion";

                comando.CommandText = query;
            
                comando.Parameters.Clear();
            
                comando.Parameters.AddWithValue("@idCurso", curso.CodigoCurso);
                comando.Parameters.AddWithValue("@nombre", curso.NombreCurso);
                comando.Parameters.AddWithValue("@descripcion", curso.Descripcion);
                comando.Parameters.AddWithValue("@cupo_alumnos", curso.CantidadAlumnos);
                comando.Parameters.AddWithValue("@turno", curso.TurnoCursada);
                comando.Parameters.AddWithValue("@horario", curso.HorarioCursada);
                comando.Parameters.AddWithValue("@inscriptos", curso.CantidadInscriptos);
                comando.Parameters.AddWithValue("@dia", curso.DiasCursada);
                comando.Parameters.AddWithValue("@condicion", codigoAModificar);

                var filasAfectadas = comando.ExecuteNonQuery();

            }
            catch (Exception)
            {
                //throw;
                conexion.Close();
            }
        }

        public static Alumno MapAlumno(IDataRecord reader)
        {

            var legajo = Convert.ToInt32(reader["LEGAJO"]);
            var nombre = reader["NOMBRE"].ToString();
            var dni = reader["DNI"].ToString();
            var usuario = reader["USUARIO"].ToString();
            var password = reader["PASSWORD"].ToString();
            var direccion = reader["DIRECCION"].ToString();
            var email = reader["EMAIL"].ToString();
            var telefono = reader["TELEFONO"].ToString();
            var changepassvalue = Convert.ToInt32(reader["CHANGEPASS"]);

            var alumno = new Alumno(legajo, nombre, dni, usuario, password, direccion, email,telefono, changepassvalue == 1);
            
            return alumno;
        }

        public static T DataBaseReadRegistro<T>(Func<IDataRecord, T> mapeo, int legajo1)
        {
            List<T> lista = new List<T>();
            Console.WriteLine("query");
            try
            {
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
                
                comando.CommandText = $@"SELECT LEGAJO,NOMBRE,DNI,USUARIO,PASSWORD,DIRECCION,EMAIL,TELEFONO,CHANGEPASS FROM ALUMNOS WHERE LEGAJO = {legajo1}";
                using (var reader = comando.ExecuteReader())
                {
                    if (reader.Read()) // Cambio realizado aquí
                    {
                        T objeto = mapeo(reader);

                        return objeto;
                    }
                    else
                    {
                        Console.WriteLine("No se encontraron filas");
                        return default(T);
                    }
                }
            }
            catch (Exception ex)
            {
                // Registra o maneja la excepción apropiadamente
                Console.WriteLine($"Ocurrió un error: {ex.Message}");
                return default(T);
            }
            finally
            {
                conexion.Close();
            }
        }
        public static Alumno leer(int numero) 
        {
            return DataBaseReadRegistro(MapAlumno, numero);
            
        }

        public static List<Alumno> LeerListaAlumnos() 
        {
            return DataBaseOpRead<Alumno>(MapAlumno, Query.QuerySelectAlumno);
        }

    }
}
