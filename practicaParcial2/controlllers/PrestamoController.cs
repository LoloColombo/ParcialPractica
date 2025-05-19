using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using views;
using Models;
using System.IO;
using Repository;

namespace controlllers
{
    public class PrestamoController
    {
        private List<Prestamo> prestamoList = new List<Prestamo>();
        private LibroController lController;
        private UsuarioController uController;
        private string ruta = Path.Combine("Repository", "Data", "Ordenes");

        public PrestamoController()
        {
            lController = new LibroController();
            uController = new UsuarioController();
            obtenerDatos();

        }

        private void obtenerDatos()
        {
            prestamoList = Repository<Prestamo>.ObtenerTodos(ruta);
        }

        private void guardarDatos()
        {
            Repository<Prestamo>.GuardarLista(ruta, prestamoList);
        }

        public void createPrestamo()
        {
            Usuario nuevoUser = uController.loadUser();
            List<Libro> nuevaListaLibros = lController.loadLibroList();

            if (nuevoUser == null && nuevaListaLibros == null && nuevaListaLibros.Count==0)
            {
                PrestamoView.printText("ERROR en los datos del prestamo");
                return;
            }

            Prestamo nuevoPrestamo = new Prestamo();

            nuevoPrestamo.usuario = nuevoUser;
            nuevoPrestamo.libros = nuevaListaLibros;
            prestamoList.Add(nuevoPrestamo);
            guardarDatos();
            PrestamoView.printText("Prestamo realizado correcrtamente");
            
        }

        public void showPrsetamo()
        {
            if (prestamoList.Count > 0)
            {
                for(int i=0; i<prestamoList.Count; i++){
                    PrestamoView.printText("---------------------");
                    PrestamoView.printText("");
                    uController.showUser(prestamoList[i].usuario);
                    PrestamoView.printText("---------------------");
                    lController.showLibroList(prestamoList[i].libros);
                    PrestamoView.printText("---------------------");
                }
               
            }
            else
            {
                PrestamoView.printText("ERROR no hay prestamos");
            }
        }

        public void deletePrestamo()
        {
            showPrsetamo();
           int indexEliminar = PrestamoView.selectPrestamo();

            if(indexEliminar<0 || indexEliminar > prestamoList.Count)
            {
                Console.WriteLine(" Prestamo fuera de rango");
                return;
            }

            prestamoList.RemoveAt(indexEliminar);
            guardarDatos();
            PrestamoView.printText("Prestamo eliminado correctamente");
        }

        public void updatePrsetamo()
        {
            showPrsetamo();
            int indexUpdate = PrestamoView.selectPrestamo();

            if (indexUpdate < 0 || indexUpdate > prestamoList.Count)
            {
                Console.WriteLine(" Prestamo fuera de rango");
                return;
            }

            Usuario nuevoUser = uController.loadUser();
            List<Libro> nuevaListaLibros = lController.loadLibroList();

            if (nuevoUser == null && nuevaListaLibros == null && nuevaListaLibros.Count == 0)
            {
                PrestamoView.printText("ERROR en los datos del prestamo");
                return;
            }

            prestamoList[indexUpdate].usuario = nuevoUser;
            prestamoList[indexUpdate].libros = nuevaListaLibros;

            guardarDatos();
            PrestamoView.printText("Prestamo actualizado correctamente");


        }

    }

}
