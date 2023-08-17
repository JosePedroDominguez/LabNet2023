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
        private static List<TransportePublico> transportes = new List<TransportePublico>();
        private static int taxisRegistrados = 0;
        private static int omnibusRegistrados = 0;

        private static void Main(string[] args)
        {
            while (true)
            {
                MostrarMenu();
                int opcion;
                bool opcionValida = int.TryParse(Console.ReadLine(), out opcion);
                Console.Clear();

                if (!opcionValida)
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                    Console.ReadLine();
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        RegistrarTaxi();
                        break;
                    case 2:
                        RegistrarOmnibus();
                        break;
                    case 3:
                        MostrarInformacion();
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Por favor, elija una opción válida.");
                        break;
                }
            }
        }
        private static void MostrarMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n         ╔════════════════════════════════════╗");
            Console.WriteLine("         ║          Bienvenido                ║");
            Console.WriteLine("         ║    Elija el tipo de transporte:    ║");
            Console.WriteLine("         ║        1. Taxi                     ║");
            Console.WriteLine("         ║        2. Ómnibus                  ║");
            Console.WriteLine("         ║        3. Finalizar                ║");
            Console.WriteLine("         ║                                    ║");
            Console.WriteLine("         ╚════════════════════════════════════╝\n\n");
        }
        private static void RegistrarTaxi()
        {
            if (taxisRegistrados >= 5)
            {
                Console.WriteLine("Ya se han registrado 5 taxis. No es posible registrar más.");
                Console.ReadLine();
                return;
            }

            int canPasajerosTaxi = SolicitarCantidadPasajeros(1, 4);
            Taxi taxi = new Taxi(canPasajerosTaxi);
            transportes.Add(taxi);
            taxisRegistrados++;
        }

        private static void RegistrarOmnibus()
        {
            if (omnibusRegistrados >= 5)
            {
                Console.WriteLine("Ya se han registrado 5 Ómnibus. No es posible registrar más.");
                Console.ReadLine();
                return;
            }

            int canPasajerosOmnibus = SolicitarCantidadPasajeros(1, 120);
            Omnibus omnibus = new Omnibus(canPasajerosOmnibus);
            transportes.Add(omnibus);
            omnibusRegistrados++;
        }

        private static int SolicitarCantidadPasajeros(int min, int max)
        {
            int cantidadPasajeros = 0;
            bool cantidadValida = false;

            while (!cantidadValida)
            {
                Console.WriteLine($"Ingrese la cantidad de pasajeros ({min}-{max}):");
                if (int.TryParse(Console.ReadLine(), out cantidadPasajeros))
                {
                    if (cantidadPasajeros >= min && cantidadPasajeros <= max)
                    {
                        cantidadValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Cantidad inválida. Por favor, ingrese una cantidad válida.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
                }
            }

            return cantidadPasajeros;
        }

        private static void MostrarInformacion()
        {
            if (taxisRegistrados >= 5 && omnibusRegistrados >= 5)
            {
                Console.WriteLine("Cantidad de pasajeros en cada transporte:\n");
                foreach (var itm in transportes)
                {
                    if (itm is Taxi taxiInfo)
                    {
                        Console.WriteLine($"Taxi {taxiInfo.NumeroTaxi}: {itm.CanPasajeros} pasajeros");
                    }
                    else if (itm is Omnibus omnibusInfo)
                    {
                        Console.WriteLine($"Ómnibus {omnibusInfo.NumeroOmnibus}: {itm.CanPasajeros} pasajeros");
                    }
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Deben registrarse 5 taxis y 5 ómnibus antes de mostrar la información.");
                Console.ReadLine();
            }
        }
    }
}
