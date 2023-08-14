using PrecticaDosPOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrecticaDosPOO
{




    class Program
    {
        static void Main(string[] args)
        {
            Logic custom = new Logic();

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Punto 1 ");
            custom.PuntoUno();

            Console.WriteLine("Punto 2 ");
            custom.PuntoDos();

            Console.ReadKey();

            Console.WriteLine("Punto 3 ");
            try
            {
                custom.ThrowException();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Excepción capturada: {ex.Message}, Tipo: {ex.GetType()}");
            }

            Console.ReadKey();

            Console.WriteLine("Punto 4 ");
            try
            {
                custom.ThrowExceptionCustomized("Mensaje de excepción personalizada: ", -1);
            }
            catch (Excepcion e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();

            Console.WriteLine("Programa finalizado.");
            Console.ReadKey();
        }


    }


}
