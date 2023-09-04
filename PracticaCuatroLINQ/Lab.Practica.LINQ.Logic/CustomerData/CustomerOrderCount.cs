using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practica.LINQ.Logic.CustomerData
{
    public class CustomerOrderCount
    {
        private string customerID;
        private int order;
        public string CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        public int Order
        {
            get { return order; }
            set { order = value; }
        }
    }
}
