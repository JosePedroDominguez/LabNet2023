using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecticaDosPOO
{
    public static class Extension
    {
        public static string MensajeExtension(this Exception e)
        {
            //extension para devolver el mensaje 
            return ($"{e.Message} : {e.GetType()}");
        }

    }
}
