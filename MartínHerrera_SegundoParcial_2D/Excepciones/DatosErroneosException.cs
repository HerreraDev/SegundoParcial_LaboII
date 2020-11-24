using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DatosErroneosException : Exception
    {
        public DatosErroneosException() : base("Error creando pedido") { }


        public DatosErroneosException(string message) : base(message) { }
    }
}
