using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesTP
{
    public class Usuario
    {
        //public static int contador = 0;

        private string _nombre;
        private string _apellido;
        private string _legajo;
        private string _contrasenia;
        private string _dni;
        private string _direccion;
        private string _email;
        private string _telefono;
        

        public Usuario(string nombre, string apellido, string dni, string legajo, string password, string direccion, string email, string telefono) 
        {
            _nombre = nombre;
            _apellido = apellido;
            _dni = dni;
            _legajo = legajo;
            _contrasenia = password;
            _email = email;
            _telefono = telefono;
            _direccion = direccion;            
        }

        public string Nombre { get => _nombre.ToUpper().Trim(); }
        public string Apellido { get => _apellido.ToUpper().Trim();  }
        public string Dni { get => _dni.Trim(); }
        public virtual string Legajo { get => _legajo; set => _legajo =value; }
        public string Password { get => _contrasenia; set => _contrasenia = value; }
        public string Telefono { get => _telefono; }
        public string Email { get => _email.ToUpper(); set => _email = value.Trim(); }
        public string Direccion { get => _direccion.ToUpper(); set => _direccion = value.Trim(); }

    }
}
