using SSUABC.Models.EntidadesSolicitud;
using SSUABC.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace SSUABC.Controllers
{
    public class UsuarioController : ApiController
    {
        UsuarioServicio servicioUsuario = new UsuarioServicio();
        // GET: Usuario
        [Route("SS/Usuario")]
        [HttpGet]
        public IHttpActionResult ListarUsuarios()
        {
            return Ok(servicioUsuario.BuscarTodos());
        }

        [Route("SS/Usuario")]
        [HttpPost]
        public IHttpActionResult AgregarUsuario([FromBody] UsuarioDTO usuarioDTO)
        {
            servicioUsuario.Agregar(usuarioDTO);
            return Ok();
        }
    }
}