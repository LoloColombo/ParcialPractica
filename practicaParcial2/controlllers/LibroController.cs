using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using views;
using Models;
namespace controlllers
{
    public class LibroController
    {
        public List<Libro> loadLibroList()
        {
           return LibroView.loadLibroList();
        
        }

        public void showLibroList(List<Libro>list)
        {
            LibroView.showLibroList(list);
        }
    }
}
