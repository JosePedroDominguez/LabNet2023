using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecticaDosPOO
{
    public class Logic
    {

        public void ThrowException()
        {
            throw new InvalidOperationException();
        }
        public void ThrowExceptionCustomized(string message, int numero)
        {
            if (numero < 0)
            {
                throw new Excepcion(message);
            }

        }
        public void PuntoUno()
        {
            try
            {
                Division div = new Division();

                Console.WriteLine("Ingrese un número para realizar la división: ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("No se ingresó ningún valor.");
                    return;
                }

                if (!int.TryParse(input, out int valor))
                {
                    Console.WriteLine("Entrada inválida. Ingrese un valor numérico.");
                    return;
                }

                div.DivisionPorCero(valor);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("La operación ha finalizado.");
            }
        }

        public void PuntoDos()
        {
            try
            {
                Division div = new Division();
                Console.WriteLine("Ingrese divisor: ");
                int divisor;
                while (!int.TryParse(Console.ReadLine(), out divisor))
                {
                    Console.WriteLine("Entrada inválida. Ingrese un valor numérico para el divisor: ");
                }

                Console.WriteLine("Ingrese dividendo: ");
                int dividendo;
                while (!int.TryParse(Console.ReadLine(), out dividendo))
                {
                    Console.WriteLine("Entrada inválida. Ingrese un valor numérico para el dividendo: ");
                }

                int resultado = div.DivisionIngresada(dividendo, divisor);
                Console.WriteLine("El resultado de la división es: {0}", resultado);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: ¡Solo Chuck Norris divide por cero!");
                Console.WriteLine("Seguramente ingresó una letra o no ingresó nada!: {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("");
            }
        }
    }
}
