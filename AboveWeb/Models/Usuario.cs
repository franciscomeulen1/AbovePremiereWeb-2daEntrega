using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbovePremiereWeb.Models
{
    public class Usuario
    {
        private string nombre;
        private string apellido;
        private string userName;
        private string pwd;
        private string email;
        private string licencia;

        public Usuario(string nombre, string apellido, string userName, string pwd, string email, string licencia)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.userName = userName;
            this.pwd = pwd;
            this.email = email;
            this.licencia = licencia;
        }
        public string getUserName()
        {
            return userName;
        }
        public string getPwd()
        {
            return pwd;
        }

    }
}
