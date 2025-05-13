using controllers;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var controller = new OrderController();
            controller.LoadOrders();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Crear nueva orden");
                Console.WriteLine("2. Mostrar todas las órdenes");
                Console.WriteLine("3. Eliminar orden por ID de cliente");
                Console.WriteLine("4. Actualizar cliente en una orden");
                Console.WriteLine("5. Salir");

                Console.Write("Seleccione una opción: ");
                var opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        //Lógica
                        break;
                    case "2":
                        //Lógica
                        break;
                    case "3":
                        //Lógica
                        break;
                    case "4":
                        //Lógica
                        break;
                    case "5":
                        return;
                    default:
                        {
                            Console.WriteLine("ERROR: Ingrese una opcion valida");
                        }
                        break;

                }

                Console.ReadKey();
                
            }
          
        }
    }
}
