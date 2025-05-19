using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Usuario
    {
        public int id {  get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }

        public Usuario() { }
        public Usuario(int id, string nombre, string apellido, string email)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
        }
    }
}
