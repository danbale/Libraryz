
using SSUABC.Repositorios.Repositorio_Generico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SSUABC.Models.EntidadesSolicitud;

namespace SSUABC.Repositorios
{
    public class UsuarioRepositorioImpl : RepostorioCRUD<Usuario>, IUsuarioRepositorio
    {
     
        public UsuarioRepositorioImpl(DbContext context) : base(context)
        {
        }

        public Usuario BuscarPorCorreo(string correo)
        {
            EntidadesSS context = new EntidadesSS();

            var usuario = from u in context.Usuarios
                          where u.Correo == correo
                          select u;
            Usuario usuarioUABC = usuario.First<Usuario>();
            return usuarioUABC;
        }
    }
}