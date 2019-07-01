using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Usuario
    {
        string user;
        string password;
        bool autenticado;

        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }
        public bool Autenticado { get => autenticado; set => autenticado = value; }

        public Usuario()
        {
            autenticado = false;
        }
    }
}
