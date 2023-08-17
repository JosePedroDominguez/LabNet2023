using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUnoPOO
{
    public class Omnibus : TransportePublico
    {
        private static int contadorOmnibus = 0;
        private int numeroOmnibus;
        public Omnibus(int canPasajeros) : base(canPasajeros)
        {
            contadorOmnibus++;
            numeroOmnibus = contadorOmnibus;
        }
        public int NumeroOmnibus
        {
            get { return numeroOmnibus; }
        }
        public override void Avanzar()
        {         
        }
        public override void Detenerse()
        {          
        }

    }
}
