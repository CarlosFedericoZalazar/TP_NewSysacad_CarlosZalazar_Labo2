using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using BibliotecaClasesTP;

namespace BibliotecaClasesTP
{
    public static class Validador
    {
        /// <summary>
        /// VALIDA QUE EL TEXTO RECIBIDO SOLO TENGA CARACTERES ALFABETICOS
        /// </summary>
        /// <param name="cadena">STRING A EVALUAR</param>
        /// <returns>TRUE:VALIDO, FALSE:INVALIDO</returns>
        static public bool ValidarTexto(string cadena) 
        {
            string patron = @"^[a-zA-Z,.\-\s]+$";
            
            return Regex.IsMatch(cadena, patron);
        }

        /// <summary>
        /// VALIDA QUE EL TEXTO RECIBIDO SOLO TENGA CARACTERES NUMERICOS
        /// </summary>
        /// <param name="cadena">STRING A EVALUAR</param>
        /// <returns>TRUE:VALIDO, FALSE:INVALIDO</returns>
        static public bool ValidarNumeros(string cadena) => int.TryParse(cadena, out _);

        public static bool ValidarUsuario(string user, out bool admin)
        {
            bool userOk = false;
            admin = false;
            bool adminOk = ValidarAdministrador(user);

            if (adminOk)
            {
                admin = true;
            }
            else
            {
                userOk = ValidarNumeros(user);
            }
            return userOk;
        }
        /// <summary>         
        /// VALIDA SI EL FORMATO DE USUARIO CORRESPONDE A UN ADMNISTRADOR
        /// </summary>
        /// <param name="usuario">PARAMETRO A VALIDAR</param>
        /// <returns>TRUE, SI HAY COICIDENCIA</returns>
        public static bool ValidarAdministrador(string usuario) 
        {
            string patron = @"^admin([0-9]+)$";    
            Match match = Regex.Match(usuario, patron);
            return match.Success;
        } 

        public static bool ValidarCurso(string curso)
        {
            string patron = @"^[C][1-4][A][0-9]$";
            bool cursoOk = false;
 
            Match match = Regex.Match(curso, patron); // match.Success para para saber el valor del objeto devuelto.

            if (match.Success)
            {
                cursoOk = true;
            }
            return cursoOk;
        }
        /// <summary>
        /// BUSCA COINCIDENCIA USUARIO/PASS EN REGISTROS DE ADMNISTRADOR DEL ARCHIVO
        /// </summary>
        /// <param name="usuario">USUARIO INGRESADO POR USUSARIO</param>
        /// <param name="pass">PASS INGRESADO POR USUARIO</param>
        /// <returns>OBJETO ADMINISTRADOR, COICINDENCIA ENCONTRADA. NULL SIN REGISTRO</returns>
        public static Administrador ValidarExistenciaUser(List<Administrador> listaAdministradores, string usuario, string pass)
        {            
            foreach (Administrador itemAdministrador in listaAdministradores)
            {
                bool validador = GestorDeClases.Hash.ValidarHash(pass, itemAdministrador.Password);
                if (usuario == itemAdministrador.Legajo && validador) // pass == itemAdministrador.Password)
                {
                    return itemAdministrador;
                }
            }
            return null;
        }

        public static Alumno ValidarExistenciaUser(List<Alumno> listaAlumnos, string usuario, string pass)
        {
            foreach (Alumno itemAlumno in listaAlumnos)
            {
                if (usuario == itemAlumno.Legajo && GestorDeClases.Hash.ValidarHash(pass, itemAlumno.Password))
                {
                    return itemAlumno;
                }
            }
            return null;
        }

        public static bool ValidarExistenciaDeRegistro(Alumno estudiante) 
        {
            var listaEstudiantes = GestorDeClases.ExtraerListaEstudiantes();

            foreach (var itemEstudiante in listaEstudiantes) 
            {
                if (estudiante.Dni == itemEstudiante.Dni) 
                {
                    return false;
                }            
            }
            return true;
        }

        public static bool ValidarExistenciaDeRegistro(Curso curso)
        {
            var listaCursos = GestorDeClases.ExtraerListaCursos();

            foreach (var itemCurso in listaCursos)
            {
                if (curso == itemCurso)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool ValidarCantidadAlumnos(string stringNumero, int maximo)
        {
            int numero;
            bool numeroOk = false;
            if (int.TryParse(stringNumero, out numero))
            {
                if (numero > 0 && numero <= maximo)
                {
                    numeroOk = true;
                }
            }
            return numeroOk;
        }

        public static bool ValidarCoincidenciaCodigoCurso(List<string> listaCursoAlumno, string curso) 
        {
            foreach (string item in listaCursoAlumno) 
            {
                if(item == curso)return true;
            }
            return false;
        }

        public static bool ValidarFormatoDni(string dni)
        {
            string patron = @"^([0-9]{7}|[0-9]{8})$";
            if (Regex.IsMatch(dni, patron))
            {
                return true;
            }
            return false;
        }

        public static bool ValidarEmail(string email) 
        {
            string patron = @"[A-Z.-]+@[A-Z\d\.-]+\.[A-Z]{2,3}$";
            
            Match match = Regex.Match(email, patron);
            return match.Success;
        }





    }
}