using SSUABC.Models.EntidadesUsuarioUABC;
using SSUABC.Repositorios;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SSUABC.Models.EntidadesUsuarioFIAD;

namespace SSUABC.Repositorios
{
    public class UsuarioUABCRepositorioImpl : IUsuarioUABCRepositorio
    {

        public Models.EntidadesUsuarioFIAD.Usuario BuscarUsuarioFIAD(string correo)
        {
            UsuariosFIAD context = new UsuariosFIAD();

            var usuario = from u in context.Usuarios
                          where u.Email == correo
                          select u;
            Models.EntidadesUsuarioFIAD.Usuario usuarioFIAD = usuario.First<Models.EntidadesUsuarioFIAD.Usuario>();
            return usuarioFIAD;

        }

        public Models.EntidadesUsuarioUABC.Usuario BuscarUsuarioUABC(string correo)
        {
            UsuariosUABC context = new UsuariosUABC();

            var usuario = from u in context.Usuarios
                          where u.Email == correo
                          select u;
            Models.EntidadesUsuarioUABC.Usuario usuarioUABC = usuario.First <Models.EntidadesUsuarioUABC.Usuario>();
            return usuarioUABC;
                        
        }
    }
}