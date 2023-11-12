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

        public static string QuerySelectCursosALumno() => $@"SELECT CURSOS.ID_CURSO,CURSOS.NOMBRE,CURSOS.DESCRIPCION,CURSOS.CUPO_ALUMNOS,CURSOS.TURNO,CURSOS.DIA,CURSOS.HORARIO,CURSOS.INSCRIPTOS" +
                                                            " FROM CURSOS " +
                                                            "JOIN INSCRIPCIONES ON CURSOS.ID_CURSO = INSCRIPCIONES.ID_CURSO";
        
        public static string QueryInscribirCursosALumno() => $@"INSERT INTO INSCRIPCIONES (LEGAJO,ID_CURSO) VALUES (@legajo, @id_curso)";

        public static string QueryDesinscribirCursosALumno() => $@"DELETE FROM INSCRIPCIONES WHERE ID_CURSO = @id_curso AND LEGAJO = @legajo";




        //DELETE FROM ALUMOS; --> BORRAR CONTENIDO DE TABLA

        // DBCC CHECKIDENT('nombre_de_tu_tabla', RESEED, 1999); --> REICIAR AUTOINCREMENTAL A 2000



    }
}
