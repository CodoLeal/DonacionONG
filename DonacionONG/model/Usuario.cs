using System;
using System.Collections.Generic;
using System.Text;

namespace DonacionONG.model
{
    internal class Usuario
    {
        private int id;
        private string nombreUsuario;
        private string password;

        public Usuario(int id, string nombreUsuario, string password)
        {
            this.id = id;
            this.nombreUsuario = nombreUsuario;
            this.password = password;
        }

        public int Id { get => id; set => id = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Password { get => password; set => password = value; }
    }
}
