using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using views;
using Models;

namespace controlllers
{
    public class UsuarioController
    {
        public Usuario loadUser()
        {
            return UsuarioView.loadUsuario();
        }

        public void showUser(Usuario user)
        {
            UsuarioView.showUsuario(user);
        }

    }
}
