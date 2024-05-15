using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static double recaudacion;
        static int CantIngresos;
        static void ImprimirMenu()
        {
            Console.WriteLine("Eliga una opción \n1 - Verificar Acceso \n2 - Imprimir recaudación \n3 - Mostrar cantidad de accesos \nOtro - Terminar");
        }

        static void acceso()
        {
            int ticket;
            Console.WriteLine("Si no tene tike o esta vencido pone 0, si esta bueno manda 1");
            ticket = Convert.ToInt32(Console.ReadLine());
            if (ticket == 0)
            {
                generarTicket();
            }
        }

        static void generarTicket()
        {
            int tipoVehiculo;
            int i;

            Console.WriteLine("Ingrese 0 si ingresa caminando");
            tipoVehiculo = Convert.ToInt32(Console.ReadLine());
            if (tipoVehiculo <> 0)

            Console.WriteLine("Ingrese cuantos vehiculos quiere ingresar");
            Console.WriteLine("0 - A pata \n1 - Moto \n2 - Auto \n3 - La Camio \n4 - Buggy \n5 - Lanchita");

        }
        static void mostrarIngresos()
        {

        }

        static void mostrarCaja()
        {

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
                        }break;
                    case 2: 
                        {
                            mostrarIngresos();
                        }break;
                    case 3:
                        {
                            mostrarCaja();
                        }break;
                }
                ImprimirMenu();
                Console.WriteLine("Ingrese la opción");
                opcion = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
