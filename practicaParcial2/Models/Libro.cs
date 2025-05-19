using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Libro
    {
        public string titulo { get; set; }
        public string autor { get; set; }
        public bool disponible { get; set; }
        public double precio { get; set; }

        public Libro() { }
        public Libro(string titulo, string autor, bool disponible ,double precio)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.disponible = false;
            this.precio = precio;
        }

        public double PrecioFinal()
        {
            return precio * 1.21;
        }

    }
}
