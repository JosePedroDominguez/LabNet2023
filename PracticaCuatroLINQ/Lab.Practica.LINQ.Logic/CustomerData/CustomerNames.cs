using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practica.LINQ.Logic.CustomerData
{
    public class CustomerNames
    {
        private string nameUpper;
        private string nameLower;
        public string NameUpper
        {
            get { return nameUpper; }
            set { nameUpper = value; }
        }
        public string NameLower
        {
            get { return nameLower; }
            set { nameLower = value; }
        }
    }
}
