using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUnoPOO
{
    public class Taxi : TransportePublico
    {
        private static int contadorTaxis = 0;
        private int numeroTaxi;
        public Taxi(int canPasajeros) : base(canPasajeros)
        {
            contadorTaxis++;
            numeroTaxi = contadorTaxis;
        }
        public int NumeroTaxi
        {
            get { return numeroTaxi; }
        }
        public override void Avanzar()
        {
            Console.WriteLine("avanzando.");
        }
        public override void Detenerse()
        {
            Console.WriteLine("frenando");
        }


    }
}
