using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUnoPOO
{
    public abstract class TransportePublico
    {
        protected int canPasajeros;
        public TransportePublico(int canPasajeros)
        {
            this.canPasajeros = canPasajeros;

        }
        public abstract void Avanzar();
        public abstract void Detenerse();
        public int CanPasajeros
        {
            get { return canPasajeros; }
            set { canPasajeros = value; }
        }
    }
}
