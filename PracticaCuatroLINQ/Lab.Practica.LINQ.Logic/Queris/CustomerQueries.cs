using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Practica.LINQ.Entities;
using Lab.Practica.LINQ.Logic.CustomerData;
namespace Lab.Practica.LINQ.Logic.Queris
{
    public class CustomerQueries : BaseLogic
    {
        public Customers TraerCliente(string id)
        {
            var customer = context.Customers.Find(id.ToUpper());
            if (customer == null)
            {
                throw new ExcepcionPersonalizada();
            }
            return customer;

        }
        public List<Customers> DeWa()
        {
            var customers = context.Customers.Where(c => c.Region == "WA");
            return customers.ToList();
        }
        public List<CustomerNames> Nombres()
        {
            var customers = from customer in context.Customers
                            select new CustomerNames()
                            {
                                NameLower = customer.ContactName.ToLower(),
                                NameUpper = customer.ContactName.ToUpper()
                            };
            return customers.ToList();
        }
        public List<CustomerJoin> OrdenFecha()
        {
            var customerOrders = from order in context.Orders
                                 join customer in context.Customers on
                                    order.CustomerID equals customer.CustomerID
                                 where customer.Region == "WA" && order.OrderDate > new DateTime(1997, 1, 1)
                                 select new CustomerJoin()
                                 {
                                     CustomerName = customer.ContactName,
                                     OrderDate = (DateTime)order.OrderDate
                                 };
            return customerOrders.ToList();
        }
        public List<Customers> WaTopTres()
        {
            var customers = (from customer in context.Customers
                             where customer.Region == "WA"
                             select customer)
                          .Take(3);
            return customers.ToList();
        }
        public List<CustomerOrderCount> ClienteOrdenesAsociadas() 
        {
            var customerOrders = from customers in context.Customers
                                 join orders in context.Orders on
                                    customers.CustomerID equals orders.CustomerID
                                 group customers by customers.CustomerID into cantidad
                                 select new CustomerOrderCount()
                                 {
                                     CustomerID = cantidad.Key,
                                     Order = cantidad.Count()
                                 };
            return customerOrders.ToList();
        }
    }
}
