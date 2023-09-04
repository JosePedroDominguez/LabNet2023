using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Lab.Practica.LINQ.Entities;

namespace Lab.Practica.LINQ.Logic.Queries
{
    public class CategoriesQueries : BaseLogic
    {
        public List<Categories> CategoríasAsociadasProduc()
        {
            var categoriesD = from categories in context.Categories
                              join products in context.Products on
                                categories.CategoryID equals products.CategoryID
                              select categories;
            return categoriesD.ToList();
        }
    }
}

