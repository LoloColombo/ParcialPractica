using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace views
{
    public static class UsuarioView
    {

        public static Usuario loadUsuario()
        {
            try
            {
                Console.WriteLine(" Ingrese el id del usuario");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine(" Ingrese el nombre del usuario");
                string nombre= Console.ReadLine();
                Console.WriteLine(" Ingrese el apellido del usuario");
                string apellido= Console.ReadLine();
                Console.WriteLine(" Ingrese el email del usuario");
                string email = Console.ReadLine();

                Usuario usuario = new Usuario(id, nombre, apellido, email);
                return usuario;
            }
            catch(FormatException)
            {
                Console.WriteLine("ERROR en el formato");
                return null;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"ERROR al cargar usuario {ex}");
                return null;
            }
        }

        public static void showUsuario(Usuario user)
        {
            Console.WriteLine($"id{user.id}");
            Console.WriteLine($"nombre{user.nombre}");
            Console.WriteLine($"apellido{user.apellido}");
            Console.WriteLine($"email{user.email}");
        }


    }
}
