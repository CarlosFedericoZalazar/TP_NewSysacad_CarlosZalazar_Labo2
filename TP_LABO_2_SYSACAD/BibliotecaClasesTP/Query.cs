using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesTP
{
    public class Query
    {
        public static string QuerySelectCurso() => $@"SELECT ID_CURSO,NOMBRE,DESCRIPCION,CUPO_ALUMNOS, TURNO, HORARIO, INSCRIPTOS, DIA FROM CURSOS";

        public static string QuerySelectAlumno() => $@"SELECT LEGAJO,NOMBRE,DNI,USUARIO,PASSWORD,DIRECCION,EMAIL,TELEFONO,CHANGEPASS FROM ALUMNOS";


    }
}
