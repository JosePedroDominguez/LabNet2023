using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUnoPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TransportePublico> transportes = new List<TransportePublico>();
            while (true)
            {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("         ╔════════════════════════════════════╗");
            Console.WriteLine("         ║          Bienvenido                ║");
            Console.WriteLine("         ║    Elija el tipo de transporte:    ║");
            Console.WriteLine("         ║        1. Taxi                     ║");
            Console.WriteLine("         ║        2. Ómnibus                  ║");
            Console.WriteLine("         ║        3. Finalizar                ║");
            Console.WriteLine("         ║                                    ║");
            Console.WriteLine("         ╚════════════════════════════════════╝");
            Console.WriteLine("");
            Console.WriteLine("");
                        
            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch(opcion) 
            {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("     Ingrese la cantidad de pasajeros para el Taxi:");
                        Console.WriteLine("");
                        int canPasajerosTaxi = 0;
                        bool cantidadValida = false;
                        while (!cantidadValida)
                        {
                            if (int.TryParse(Console.ReadLine(), out canPasajerosTaxi))
                            {
                                Console.Clear();
                                if (canPasajerosTaxi >= 1 && canPasajerosTaxi <= 4)
                                {
                                    cantidadValida = true;
                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("     Cantidad inválida. Por favor, ingrese una cantidad válida (1-4).");
                                    Console.WriteLine("");
                                }
                                
                            }

                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("     Entrada inválida. Por favor, ingrese un número válido.");
                                Console.WriteLine("");
                            }
                        }
                        Taxi taxi = new Taxi(canPasajerosTaxi);
                        transportes.Add(taxi);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("     Ingrese la cantidad de pasajeros para el Ómnibus:");
                        Console.WriteLine("");
                        int canPasajerosOmnibus = 0;
                        cantidadValida = false;
                        while (!cantidadValida)
                        {
                            if (int.TryParse(Console.ReadLine(), out canPasajerosOmnibus))
                            {
                                Console.Clear();
                                if (canPasajerosOmnibus >= 1 && canPasajerosOmnibus <= 100)
                                {
                                    cantidadValida = true;
                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("     Cantidad inválida. Por favor, ingrese una cantidad válida (1-120).");
                                    Console.WriteLine("");
                                }
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("     Entrada inválida. Por favor, ingrese un número válido.");
                                Console.WriteLine("");
                            }
                        }
                        Omnibus omnibus = new Omnibus(canPasajerosOmnibus);
                        transportes.Add(omnibus);
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("     Cantidad de pasajeros en cada transporte: ");
                        Console.WriteLine("");
                        foreach (var itm in transportes)
                        {
                            if (itm is Taxi)
                            {
                                Taxi taxiInfo = itm as Taxi;
                                Console.WriteLine("");
                                Console.WriteLine("     Taxi " + taxiInfo.NumeroTaxi +": "+ itm.CanPasajeros+ " pasajeros " );
                                Console.WriteLine("");

                            }
                            else if (itm is Omnibus)
                            {
                                Omnibus omnibusInfo = itm as Omnibus;
                                Console.WriteLine("");
                                Console.WriteLine("     Ómnibus " + omnibusInfo.NumeroOmnibus + ": "+ itm.CanPasajeros + " pasajeros");
                                Console.WriteLine("");

                            }
                            
                        }
                        Console.ReadLine();
                        return;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine("     Opción inválida. Por favor, elija una opción válida.");
                        Console.WriteLine("");
                        break;
                }

            }           
            
        }
    }
}
