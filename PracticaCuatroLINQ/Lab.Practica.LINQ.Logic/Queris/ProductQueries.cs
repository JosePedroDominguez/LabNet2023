using Lab.Practica.LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Practica.LINQ.Logic.Queris
{
    public class ProductQueries : BaseLogic
    {
        public List<Products> SinStock()
        {
            var products = context.Products.Where(p => p.UnitsInStock == 0);
            return products.ToList();
        }
        public List<Products> MayorPrecioUnitario()
        {
            var products = context.Products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);
            return products.ToList();
        }
        public Products TraerPrimero()
        {
            var product = context.Products.First();
            return product;
        }

        public Products PrimerElemento()
        {

            var product = context.Products.Where(p => p.ProductID == 789).FirstOrDefault();
            return product;

        }
        public List<Products> OrdenarPorNombre()
        {
            var products = from product in context.Products
                           orderby product.ProductName
                           select product;
            return products.ToList();
        }

        public List<Products> OrdenarPorStockUnit()
        {
            var products = context.Products.OrderByDescending(p => p.UnitsInStock);
            return products.ToList();
        }
    }
}
