using SSUABC.Models.EntidadesSolicitud;
using SSUABC.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace SSUABC.Controllers
{
    public class SesionController : ApiController
    {
        SesionServicio sesionServicio = new SesionServicio();

        [Route("SS/Login")]
        [HttpPost]
        public IHttpActionResult Index(UsuarioDTO usuario)
        {
            return Ok(sesionServicio.InicioSesion(usuario));
        }
    }
}