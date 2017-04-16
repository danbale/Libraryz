
using SSUABC.Models.EntidadesSolicitud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSUABC.Repositorios
{
    interface IUsuarioRepositorio
    {
        Usuario BuscarPorCorreo(String correo);
    }
}