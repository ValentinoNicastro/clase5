using System;
using System.Runtime.InteropServices;

namespace Ejercicio1
{
    internal class Program
    {
        static double recaudacion;
        static int CantIngresos;
        static void ImprimirMenu()
        {
            Console.WriteLine("Eliga una opción \n1 - Verificar Acceso \n2 - Mostrar ingresos \n3 - Mostrar recaudacion \nOtro - Terminar");
        }

        static void acceso()
        {
            int ticket;
            Console.WriteLine("Si no tene ticket o esta vencido pone 0, si esta bueno manda 1");
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
                Console.WriteLine("Ingrese con que vehiculo ingresa");
                Console.WriteLine("1 - A pata \n2 - Moto \n3 - Auto \n4 - La Camio \n5 - Buggy \n6 - Lanchita");
                Console.WriteLine("En caso de ya haber ingresado los vehiculos o de no ingresar ninguno, ponga otro valor");
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
                            Console.WriteLine("Indique cantidad de este vehiculo");
                            cantVehiculo = Convert.ToInt32(Console.ReadLine());
                            precioFinal = precioFinal + (cantVehiculo * precioVehiculo);
                            CantIngresos = cantVehiculo;
                        }
                        break;
                    case 3:
                        {
                            precioVehiculo = 1000;
                            Console.WriteLine("Indique cantidad de este vehiculo");
                            cantVehiculo = Convert.ToInt32(Console.ReadLine());
                            precioFinal = precioFinal + (cantVehiculo * precioVehiculo);
                            CantIngresos = cantVehiculo;
                        }
                        break;
                    case 4:
                        {
                            precioVehiculo = 1500;
                            Console.WriteLine("Indique cantidad de este vehiculo");
                            cantVehiculo = Convert.ToInt32(Console.ReadLine());
                            precioFinal = precioFinal + (cantVehiculo * precioVehiculo);
                            CantIngresos = cantVehiculo;
                        }
                        break;
                    case 5:
                        {
                            precioVehiculo = 5000;
                            Console.WriteLine("Indique cantidad de este vehiculo");
                            cantVehiculo = Convert.ToInt32(Console.ReadLine());
                            precioFinal = precioFinal + (cantVehiculo * precioVehiculo);
                            CantIngresos = cantVehiculo;
                        }
                        break;
                    case 6:
                        {
                            precioVehiculo = 1200;
                            Console.WriteLine("Indique cantidad de este vehiculo");
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

            Console.WriteLine("Ingrese por cuantos dias estara.");
            Console.WriteLine("De 1 a 10 dias maximo.");
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

            Console.WriteLine("El precio final de su ticket es: {0}", precioFinal);
        }
        static void mostrarIngresos()
        {
            Console.WriteLine("La cantidad de ingresos es: {0}",CantIngresos);
            Console.ReadKey();
        }

        static void mostrarCaja()
        {
            Console.WriteLine("La recaudacion total es: {0}", recaudacion);
            Console.ReadKey();
        }
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
    }
}
