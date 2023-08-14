using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecticaDosPOO
{
    public class Excepcion : Exception
    {
        private string customMsg;
        public Excepcion(string customMsg) : base("mensaje de ExceptionCustom lalala")
        {
            this.customMsg = customMsg;
        }
        public override string Message => ($"{customMsg} : {base.Message}");

    }
}
