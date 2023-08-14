using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecticaDosPOO
{
    public class Division 
    {
        public void DivisionPorCero(int valor)
        {
            int resultado = valor / 0;
            Console.WriteLine("Resultado de la división: " + resultado);
        }

        public int DivisionIngresada(int dividendo, int divisor)
        {
            return dividendo / divisor;
        }

    }
}
