using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Prestamo
    {
        public Usuario usuario {  get; set; }
        public List<Libro> libros { get; set; } = new List<Libro>();

        public Prestamo() { }
         //ver si hay que hacer gets y sets no genericos
    }
}
