using Lab.Practica.LINQ.Logic.Queris;
using Lab.Practica.LINQ.Logic.CustomerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Practica.LINQ.Logic;
using Lab.Practica.LINQ.Logic.Queries;


namespace Lab.Practica.LINQ.UI
{

    class Program
    {
        static void Main(string[] args)
        {
            bool finalizar = false;

            do
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    GenerarMenu();
                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "0":
                            finalizar = true;
                            break;
                        case "1":
                            MostrarClientePorCodigo();
                            break;
                        case "2":
                            MostrarProductosSinStock();
                            break;
                        case "3":
                            MostrarProductosConPrecioAlto();
                            break;
                        case "4":
                            MostrarClientesDeWA();
                            break;
                        case "5":
                            MostrarPrimerProductoPorID();
                            break;
                        case "6":
                            MostrarNombresDeClientes();
                            break;
                        case "7":
                            MostrarClientesConOrdenesDeWA();
                            break;
                        case "8":
                            MostrarPrimerosTresClientesDeWA();
                            break;
                        case "9":
                            MostrarProductosOrdenadosPorNombre();
                            break;
                        case "10":
                            MostrarProductosOrdenadosPorStock();
                            break;
                        case "11":
                            MostrarCategoriasAsociadasAProductos();
                            break;
                        case "12":
                            MostrarPrimerProductoDeLista();
                            break;
                        case "13":
                            MostrarClientesConCantidadDeOrdenes();
                            break;
                        default:
                            Console.WriteLine("!Error, inténtelo nuevamente...");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (!finalizar);
        }

        static void GenerarMenu()
        {
            Console.WriteLine("Seleccionar el numero de la consulta o 0 para finalizar.");
            Console.WriteLine("1-Query para devolver objeto customer");
            Console.WriteLine("2-Query para devolver todos los productos sin stock");
            Console.WriteLine("3-Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad");
            Console.WriteLine("4-Query para devolver todos los customers de la Región WA");
            Console.WriteLine("5-Query para devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789");
            Console.WriteLine("6-Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula.");
            Console.WriteLine("7-Query para devolver Join entre Customers y Orders donde los customers sean de la  Región WA y la fecha de orden sea mayor a 1 / 1 / 1997.");
            Console.WriteLine("8-Query para devolver los primeros 3 Customers de la  Región WA");
            Console.WriteLine("9-Query para devolver lista de productos ordenados por nombre");
            Console.WriteLine("10-Query para devolver lista de productos ordenados por unit in stock de mayor a menor.");
            Console.WriteLine("11-Query para devolver las distintas categorías asociadas a los productos");
            Console.WriteLine("12-Query para devolver el primer elemento de una lista de productos");
            Console.WriteLine("13-Query para devolver los customer con la cantidad de ordenes asociadas");
        }
        static void MostrarClientePorCodigo()
        {
            CustomerQueries customerQueries = new CustomerQueries();
            var customer = customerQueries.TraerCliente("AROUT");
            Console.WriteLine(customer.ContactName);
            Console.ReadKey();
            Console.Clear();
        }

        static void MostrarProductosSinStock()
        {
            ProductQueries productQueries = new ProductQueries();
            productQueries.SinStock().ForEach(p => Console.WriteLine($"{p.ProductName} | {p.UnitsInStock}"));
            Console.ReadKey();
            Console.Clear();
        }

        static void MostrarProductosConPrecioAlto()
        {
            ProductQueries productQueries = new ProductQueries();
            productQueries.MayorPrecioUnitario().ForEach(p => Console.WriteLine($"{p.ProductName} | {p.UnitsInStock} | {p.UnitPrice}"));
            Console.ReadKey();
            Console.Clear();
        }

        static void MostrarClientesDeWA()
        {
            CustomerQueries customerQueries = new CustomerQueries();
            customerQueries.DeWa().ForEach(c => Console.WriteLine($"{c.ContactName} | {c.Region}"));
            Console.ReadKey();
            Console.Clear();
        }

        static void MostrarPrimerProductoPorID()
        {
            try
            {
                ProductQueries productQueries = new ProductQueries();
                var product = productQueries.PrimerElemento();

                if (product == null)
                {
                    throw new ExcepcionPersonalizada();
                }
                else
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            catch (ExcepcionPersonalizada ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        static void MostrarNombresDeClientes()
        {
            CustomerQueries customersQueries = new CustomerQueries();
            customersQueries.Nombres().ForEach(c => Console.WriteLine($"{c.NameUpper} | {c.NameLower}"));
            Console.ReadKey();
            Console.Clear();
        }

        static void MostrarClientesConOrdenesDeWA()
        {
            CustomerQueries customersQueries = new CustomerQueries();
            customersQueries.OrdenFecha().ForEach(c => Console.WriteLine($"{c.CustomerName} | {c.OrderDate.ToShortDateString()}"));
            Console.ReadKey();
            Console.Clear();
        }

        static void MostrarPrimerosTresClientesDeWA()
        {
            CustomerQueries customersQueries = new CustomerQueries();
            customersQueries.WaTopTres().ForEach(c => Console.WriteLine(c.ContactName));
            Console.ReadKey();
            Console.Clear();
        }

        static void MostrarProductosOrdenadosPorNombre()
        {
            ProductQueries productsQueries = new ProductQueries();
            productsQueries.OrdenarPorNombre().ForEach(p => Console.WriteLine(p.ProductName));
            Console.ReadKey();
            Console.Clear();
        }

        static void MostrarProductosOrdenadosPorStock()
        {
            ProductQueries productsQueries = new ProductQueries();
            productsQueries.OrdenarPorStockUnit().ForEach(p => Console.WriteLine($"{p.ProductName} | {p.UnitsInStock}"));
            Console.ReadKey();
            Console.Clear();
        }

        static void MostrarCategoriasAsociadasAProductos()
        {
            CategoriesQueries categoriesQueries = new CategoriesQueries();
            categoriesQueries.CategoríasAsociadasProduc().ForEach(c => Console.WriteLine(c.CategoryName));
            Console.ReadKey();
            Console.Clear();
        }

        static void MostrarPrimerProductoDeLista()
        {
            ProductQueries productsQueries = new ProductQueries();
            Console.WriteLine(productsQueries.TraerPrimero().ProductName);
            Console.ReadKey();
            Console.Clear();
        }

        static void MostrarClientesConCantidadDeOrdenes()
        {
            CustomerQueries customersQueries = new CustomerQueries();
            customersQueries.ClienteOrdenesAsociadas().ForEach(c => Console.WriteLine($"{c.CustomerID} | {c.Order}"));
            Console.ReadKey();
            Console.Clear();
        }
        /* CategoriesQueries categoriesQueries = new CategoriesQueries();
         CustomerQueries customersQueries = new CustomerQueries();
         ProductQueries productsQueries = new ProductQueries();
         bool finalizar = false;

         do
         {
             try
             {
                 Console.ForegroundColor = ConsoleColor.Cyan;
                 GenerarMenu();
                 string opcion = Console.ReadLine();

                 switch (opcion)
                 {
                     case "0":
                         finalizar = true;
                         break;
                     case "1":
                         var customer = customersQueries.TraerCliente("AROUT");
                         Console.WriteLine(customer.ContactName);
                         Console.ReadKey();
                         Console.Clear();
                         break;
                     case "2":
                         productsQueries.SinStock().ForEach(p => Console.WriteLine($"{p.ProductName} | {p.UnitsInStock}"));
                         Console.ReadKey();
                         Console.Clear();
                         break;
                     case "3":
                         productsQueries.MayorPrecioUnitario().ForEach(p => Console.WriteLine($"{p.ProductName} | {p.UnitsInStock} | {p.UnitPrice}"));
                         Console.ReadKey();
                         Console.Clear();
                         break;
                     case "4":
                         customersQueries.DeWa().ForEach(c => Console.WriteLine($"{c.ContactName} | {c.Region}"));
                         Console.ReadKey();
                         Console.Clear();
                         break;

                     case "5":
                         try
                         {
                             var product = productsQueries.PrimerElemento();

                             if (product == null)
                             {
                                 throw new ExcepcionPersonalizada();
                             }
                             else
                             {
                                 Console.WriteLine(product.ProductName);
                             }
                         }
                         catch (ExcepcionPersonalizada ex)
                         {
                             Console.WriteLine(ex.Message);
                         }

                         Console.WriteLine("Presiona cualquier tecla para continuar...");
                         Console.ReadKey();
                         Console.Clear();
                         break;

                     case "6":
                         customersQueries.Nombres().ForEach(c => Console.WriteLine($"{c.NameUpper} | {c.NameLower}"));
                         Console.ReadKey();
                         Console.Clear();
                         break;
                     case "7":
                         customersQueries.OrdenFecha().ForEach(c => Console.WriteLine($"{c.CustomerName} | {c.OrderDate.ToShortDateString()}"));
                         Console.ReadKey();
                         Console.Clear();
                         break;
                     case "8":
                         customersQueries.WaTopTres().ForEach(c => Console.WriteLine(c.ContactName));
                         Console.ReadKey();
                         Console.Clear();
                         break;
                     case "9":
                         productsQueries.OrdenarPorNombre().ForEach(p => Console.WriteLine(p.ProductName));
                         Console.ReadKey();
                         Console.Clear();
                         break;
                     case "10":
                         productsQueries.OrdenarPorStockUnit().ForEach(p => Console.WriteLine($"{p.ProductName} | {p.UnitsInStock}"));
                         Console.ReadKey();
                         Console.Clear();

                         break;
                     case "11":
                         categoriesQueries.CategoríasAsociadasProduc().ForEach(c => Console.WriteLine(c.CategoryName));
                         Console.ReadKey();
                         Console.Clear();
                         break;
                     case "12":
                         Console.WriteLine(productsQueries.TraerPrimero().ProductName);
                         Console.ReadKey();
                         Console.Clear();
                         break;
                     case "13":
                         customersQueries.ClienteOrdenesAsociadas().ForEach(c => Console.WriteLine($"{c.CustomerID} | {c.Order}"));
                         Console.ReadKey();
                         Console.Clear();
                         break;
                     default:
                         Console.WriteLine("!Error, intentelo nuevamente...");
                         break;
                 }
             }
             catch (Exception ex)
             {
                 Console.WriteLine(ex.Message);
             }
         } while (!finalizar);

     }*/

    }   
}
