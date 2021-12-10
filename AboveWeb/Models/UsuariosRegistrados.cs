using AbovePremiereWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AboveWeb.Models
{
    public class UsuariosRegistrados
    {
        private static List<Usuario> usuarios = new List<Usuario>();

        public UsuariosRegistrados()
        {
            generarUsuarios();
        }
        private void generarUsuarios()
        {
            usuarios.Add(new Usuario("Camila", "Perez", "cami94", "12345", "camiperez@hotmail.com", "AAAA-AAAA-1111-2222-3333"));
            usuarios.Add(new Usuario("Francisco", "Juarez", "fran94", "abc123", "francisco.fmj@hotmail.com", "AAAA-BBBB-1111-2222-3333"));
            usuarios.Add(new Usuario("Matias", "Roma", "mati94", "12345", "matiroma@hotmail.com", "AAAA-CCCC-1111-2222-3333"));
            usuarios.Add(new Usuario("Gaston", "Lopez", "gasti94", "abc123", "gastilopez@hotmail.com", "AAAA-DDDD-1111-2222-3333"));
            usuarios.Add(new Usuario("Malena", "Shroder", "malena94", "12345", "maleshroder@hotmail.com", "AAAA-EEEE-1111-2222-3333"));
        }
        
        public static List<Usuario> getUsuarios()
        {
            return usuarios;
        }
        public static void agregarUsuarios(Usuario user)
        {
            usuarios.Add(user);
        }
        
    }
}
