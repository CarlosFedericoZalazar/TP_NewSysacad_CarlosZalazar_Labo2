using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesTP
{
    public class MyExceptions
    {
        public class ValorNullException : Exception
        {
            public ValorNullException(string mensaje) : base(mensaje)
            {

            }

        }

    }
}
