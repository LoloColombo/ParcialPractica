using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace views
{
    public static class PrestamoView
    {
        public static void printText(string text)
        {
            Console.WriteLine(text);    
        }

        public static int selectPrestamo()
        {
            Console.WriteLine(" Que prestamo quiere seleccionar?");
            int index = int.Parse(Console.ReadLine());
            return index;
        }

    }
}
