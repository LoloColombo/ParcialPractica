using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace views
{
    public static class LibroView
    {

         public static List<Libro> loadLibroList()
         {
            string opcion = "n";
            List<Libro> libroList = new List<Libro>();
            do
            {

                try
                {
                    Console.WriteLine("Ingrese el titulo del libro:");
                    string titulo = Console.ReadLine();
                    Console.WriteLine("Ingrese el autro del libro:");
                    string autor = Console.ReadLine();
                    Console.WriteLine(" Ingrese el estado del libro:");
                    bool estado = bool.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el precio del producto:");
                    double precio = double.Parse(Console.ReadLine());
                    Libro nuevoLibro = new Libro(titulo, autor, estado, precio);
                    libroList.Add(nuevoLibro);
                    
                    
                }
                catch (FormatException)
                {
                    Console.WriteLine(" Formato incorrecto en las entradas");
                    return null;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($" ERROR {ex} ");
                    return null;
                }

                Console.WriteLine("Quiere ingresar otro Libro? (s/n)");
                opcion = Console.ReadLine();

            } while (opcion != "n");
            return libroList;
           
         }

         public static void showLibroList(List<Libro> list)
         {
            for(int i=0; i<list.Count; i++)
            {
                Console.WriteLine($"titulo{list[i].titulo}");
                Console.WriteLine($"autor{list[i].autor}");
                Console.WriteLine($"dispobible{list[i].disponible}");
                Console.WriteLine($"precio{list[i].PrecioFinal()}");
            }
         }

    }

    
}
