﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practica.LINQ.Logic.CustomerData
{
    public class CustomerJoin
    {
        private string customerName;
        private DateTime orderDate;
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }
        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }
    }
}
