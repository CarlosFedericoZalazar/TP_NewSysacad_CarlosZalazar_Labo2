using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsSysacadApp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        //public static FormAdmin formularioAdministrador;
        public static FormAlumno formularioAlumno;
        //public static FormRegStudent formularioRegEstudiante;
        //public static FormAdminCursos formularioAdminCursos;
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormLogin formularioLogin = new FormLogin();
            Application.Run(formularioLogin);            
            //Application.Run(new FormAlumno());
        }
    }
}
