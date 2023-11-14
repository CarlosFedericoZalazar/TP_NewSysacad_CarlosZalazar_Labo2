using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesTP
{  
    public class Alumno : Usuario
    {
        List<string> materias = new List<string>();
        private bool habilitadoCambioPass;
        //private Pagos _pagosCursada = new Pagos();
        private int _legajo;
        private string _usuario;

        public Alumno(string nombre, string apellido, string dni, string password, string direccion, string email, string telefono, bool cambioPass) : base(nombre, dni, password, direccion, email, telefono)
        {
            habilitadoCambioPass = cambioPass;
            _apellido = apellido;
            
        }

        public Alumno(int legajo,string nombre, string dni, string usuario,string password, string direccion, string email, string telefono, bool cambioPass) : base(nombre, dni, password, direccion, email, telefono)
        {
            habilitadoCambioPass = cambioPass;
            _legajo = legajo;
            _usuario = usuario;
        }

        public virtual int Legajo { get => _legajo; set => _legajo = value; }
        public string NombreApellido { get=> $"{_apellido}, {Nombre}"; }
        public List<string> ListaMaterias { get => materias; set => materias=value; }

        public string Usuario { get=>_usuario; set=>_usuario = value; }
        //public Pagos PagosCursada { get=>_pagosCursada; set=>_pagosCursada = value; }
        public bool CambioPass { get=> habilitadoCambioPass; set=> habilitadoCambioPass=value; }

        public void EnviarCredenciales(Alumno infoAlumno) 
        {
            // LOGICA PARA ENVIAR MAIL AL ESTUDIANTE
        }

        public int InscripcionMaterias(BindingList<Curso> listaCursos, int legajo) 
        {
            var listaMateriasSql = RecuperarInscripcionMaterias(legajo);
            int contadorRegistroAgregados = 0;

            foreach (Curso item in listaCursos) 
            {
                if (!listaMateriasSql.Contains(item)) 
                {
                    contadorRegistroAgregados++;
                    DataBase.GuardarInscripcion(Query.QueryInscribirCursosALumno, item.CodigoCurso, legajo);
                }       
            }
            return contadorRegistroAgregados;
        }

        public BindingList<Curso> RecuperarInscripcionMaterias(int legajo) 
        {
            BindingList<Curso> listaCursoDataGrid = new BindingList<Curso>();

            List <Curso> listaCursosAlumno = new List<Curso>();
            string filter = $" WHERE INSCRIPCIONES.LEGAJO = {Legajo}";
            listaCursosAlumno = DataBase.DataBaseOpRead<Curso>(DataBase.MapCurso, Query.QuerySelectCursosALumno, filter);
            foreach (var item in listaCursosAlumno) 
            {
                listaCursoDataGrid.Add(item);
            }
            return listaCursoDataGrid;
        }

        public void DesuscribirMaterias(int legajo, string idMateria) 
        {
            DataBase.GuardarInscripcion(Query.QueryDesinscribirCursosALumno, idMateria, legajo);
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