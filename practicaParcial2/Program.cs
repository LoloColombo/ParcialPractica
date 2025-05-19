using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using controlllers;

namespace practicaParcial2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sistema de gestion de ordenes - Beta";
            PrestamoController controller = new PrestamoController();

            int opcion = 0;
            do
            {
                Console.Clear();

                sendMessageAndColor("Gestión de Órdenes:", ConsoleColor.DarkBlue);
                sendMessageAndColor("1.", ConsoleColor.Cyan, false);
                sendMessageAndColor(" Crear orden");

                sendMessageAndColor("2.", ConsoleColor.Cyan, false);
                sendMessageAndColor(" Mostrar ordenes");

                sendMessageAndColor("3.", ConsoleColor.Cyan, false);
                sendMessageAndColor(" Actualizar orden");

                sendMessageAndColor("4.", ConsoleColor.Cyan, false);
                sendMessageAndColor(" Eliminar orden");

                sendMessageAndColor("0.", ConsoleColor.Cyan, false);
                sendMessageAndColor(" Salir del programa");

                sendMessageAndColor("Seleccione una opción: ", ConsoleColor.DarkBlue);

                try
                {
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1: controller.createPrestamo(); break;
                        case 2: controller.showPrsetamo(); Console.ReadKey(); break;
                        case 3: controller.deletePrestamo(); Console.ReadKey(); break;
                        case 4: controller.updatePrsetamo(); Console.ReadKey(); break;
                    }
                }
                catch (Exception ex)
                {
                    sendMessageAndColor($"[ERROR] Se produjo un error inesperado: {ex.Message}", ConsoleColor.Red);
                    sendMessageAndColor("Presione una tecla para continuar...");
                    opcion = 1; Console.ReadKey();
                }


            } while (opcion != 0);
        }

        private static void sendMessageAndColor(string msg, ConsoleColor color = ConsoleColor.White, bool lineBreak = true)
        {
            Console.ForegroundColor = color;
            Console.Write(msg);
            if (lineBreak) Console.WriteLine("");
        }
    }
}
