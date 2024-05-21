using System;
using System.Runtime.InteropServices;

namespace Ejercicio1
{
    internal class Program
    {
        #region Variables
        static double recaudacion;
        static int CantIngresos;
        #endregion
        #region Menu
        static void ImprimirMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╔════════════════════════╗\n║Eliga una opción        ║\n║1 - Verificar Acceso    ║\n║2 - Mostrar ingresos    ║\n║3 - Mostrar recaudacion ║\n║Otro - Terminar         ║\n╚════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion
        #region Acceso
        static void acceso()
        {
            int ticket;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Si no tene ticket o esta vencido pone 0, si esta bueno manda 1"); 
            Console.ForegroundColor = ConsoleColor.White;

            ticket = Convert.ToInt32(Console.ReadLine());
            if (ticket == 0)
                generarTicket();
            else
                CantIngresos++;

        }

        static void generarTicket()
        {
            int tipoVehiculo;
            int precioVehiculo;
            int cantVehiculo = 0;
            int i;
            double precioFinal = 0;

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ingrese con que vehiculo ingresa");
                Console.WriteLine("1 - A pata \n2 - Moto \n3 - Auto \n4 - La Camio \n5 - Buggy \n6 - Lanchita");
                Console.WriteLine("En caso de ya haber ingresado los vehiculos o de no ingresar ninguno, ponga otro valor");
                Console.ForegroundColor = ConsoleColor.White;

                tipoVehiculo = Convert.ToInt32(Console.ReadLine());

                switch (tipoVehiculo)
                {
                    case 1:
                        {
                            precioVehiculo = 100;
                            cantVehiculo = 1;
                            precioFinal = precioFinal + (cantVehiculo * precioVehiculo);
                            CantIngresos++;
                        }
                        break;
                    case 2:
                        {
                            precioVehiculo = 800;

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Indique cantidad de este vehiculo");
                            Console.ForegroundColor = ConsoleColor.White;

                            cantVehiculo = Convert.ToInt32(Console.ReadLine());
                            precioFinal = precioFinal + (cantVehiculo * precioVehiculo);
                            CantIngresos = cantVehiculo;
                        }
                        break;
                    case 3:
                        {
                            precioVehiculo = 1000;

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Indique cantidad de este vehiculo");
                            Console.ForegroundColor = ConsoleColor.White;

                            cantVehiculo = Convert.ToInt32(Console.ReadLine());
                            precioFinal = precioFinal + (cantVehiculo * precioVehiculo);
                            CantIngresos = cantVehiculo;
                        }
                        break;
                    case 4:
                        {
                            precioVehiculo = 1500;

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Indique cantidad de este vehiculo");
                            Console.ForegroundColor = ConsoleColor.White;

                            cantVehiculo = Convert.ToInt32(Console.ReadLine());
                            precioFinal = precioFinal + (cantVehiculo * precioVehiculo);
                            CantIngresos = cantVehiculo;
                        }
                        break;
                    case 5:
                        {
                            precioVehiculo = 5000;

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Indique cantidad de este vehiculo");
                            Console.ForegroundColor = ConsoleColor.White;

                            cantVehiculo = Convert.ToInt32(Console.ReadLine());
                            precioFinal = precioFinal + (cantVehiculo * precioVehiculo);
                            CantIngresos = cantVehiculo;
                        }
                        break;
                    case 6:
                        {
                            precioVehiculo = 1200;

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Indique cantidad de este vehiculo");
                            Console.ForegroundColor = ConsoleColor.White;

                            cantVehiculo = Convert.ToInt32(Console.ReadLine());
                            precioFinal = precioFinal + (cantVehiculo * precioVehiculo);
                            CantIngresos = cantVehiculo;
                        }
                        break;
                    default:
                        {

                        }
                        break;
                }

            } while (tipoVehiculo >= 2 && tipoVehiculo <= 6);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ingrese por cuantos dias estara.");
            Console.WriteLine("De 1 a 10 dias maximo.");
            Console.ForegroundColor = ConsoleColor.White;

            i = Convert.ToInt32(Console.ReadLine());

            switch(i)
            {
                case 1:
                        {
                        precioFinal = precioFinal * 1;
                        }break;
                case 2:
                        {
                            precioFinal = precioFinal * 1.20;
                        }break;
                case 3:
                        {
                            precioFinal = precioFinal * 2.20;
                        }break;
                case 4:
                        {
                            precioFinal = precioFinal * 3.20;
                        }break;
                case 5:
                        {
                            precioFinal = precioFinal * 3.80;
                        }break;
                case 6:
                        {
                            precioFinal = precioFinal * 3.80;
                        }break;
                case 7:
                        {
                            precioFinal = precioFinal * 3.80;
                        }break;
                case 8:
                        {
                            precioFinal = precioFinal * 3.80;
                        }break;
                case 9:
                        {
                            precioFinal = precioFinal * 3.80;
                        }break;
                case 10:
                        {
                            precioFinal = precioFinal * 3.80;
                        }break;
                }

            precioFinal = precioFinal * 1.21;
            precioFinal = precioFinal * 1.15;
            recaudacion = recaudacion + precioFinal;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("El precio final de su ticket es: {0}", precioFinal);
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion
        #region Ingresos
        static void mostrarIngresos()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("La cantidad de ingresos es: {0}",CantIngresos);
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion
        #region Recaudación
        static void mostrarCaja()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("La recaudacion total es: {0}", recaudacion);
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion
        #region Main
        static void Main(string[] args)
        {
            int opcion;

            ImprimirMenu();
            opcion = Convert.ToInt32(Console.ReadLine());

            while (opcion >= 1 && opcion <= 3)
            {
                switch (opcion)
                {
                    case 1:
                        {
                            acceso();
                        }
                        break;
                    case 2:
                        {
                            mostrarIngresos();
                        }
                        break;
                    case 3:
                        {
                            mostrarCaja();
                        }
                        break;
                }
                ImprimirMenu();
                Console.WriteLine("Ingrese la opción");
                opcion = Convert.ToInt32(Console.ReadLine());
            }
        }
        #endregion
    }
}
