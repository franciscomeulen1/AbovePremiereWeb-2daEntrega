using AbovePremiereWeb.Models;
using AboveWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbovePremiereWeb.Controllers
{
    [Route("/api")]
    public class ApiController : Controller
    {
        // GET: ApiController
            
            [Route("ping")]
            public string Ping()
            {
            return "Pong";
            }

            [Route("check")]
            [HttpPost]
            public IActionResult checkUser([FromBody] dynamic body)
            {

                dynamic json = JsonConvert.DeserializeObject<dynamic>(body.ToString());

                Console.WriteLine(json.user);
                Console.WriteLine(json.pwd);
                string userBody = json.user;
                string pwdBody = json.pwd;
                List<Usuario> usuarios = UsuariosRegistrados.getUsuarios();

            int i = 0;
            Usuario userEncontrado = null;
            while (i < usuarios.Count() && userEncontrado == null)
            {
                if (usuarios[i].getUserName().Equals(userBody) && usuarios[i].getPwd().Equals(pwdBody))
                {
                    return Ok(new { valid = true });
                }
                i++;
            }
            return Ok(new { valid = false });

        }



    }
}
