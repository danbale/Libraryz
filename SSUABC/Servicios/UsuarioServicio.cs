using SSUABC.Repositorios;
using SSUABC.Models.EntidadesSolicitud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSUABC.Servicios
{
    public class UsuarioServicio
    {
        private UsuarioRepositorioImpl usuarioRepositorio;
        public UsuarioServicio()
        {
            usuarioRepositorio = new UsuarioRepositorioImpl(new EntidadesSS());
        }

        public void Agregar(UsuarioDTO usuarioDTO)
        {
            Usuario usuario;
            usuario = this.TransferirDatosDTO(usuarioDTO);
            usuarioRepositorio.Agregar(usuario);
        }


        public List<UsuarioDTO> BuscarTodos()
        {
            List<UsuarioDTO> usuariosDTO = new List<UsuarioDTO>();
            List<Usuario> usuarios = usuarioRepositorio.BuscarTodos().ToList();
            foreach (Usuario usuario in usuarios)
            {

                usuariosDTO.Add(this.TransferirDatosEntidad(usuario));
                
            }
           
            return usuariosDTO;
        }

        private Usuario TransferirDatosDTO(UsuarioDTO usuarioDTO)
        {
            Usuario usuario = new Usuario();
            usuario.Id = usuarioDTO.Id;
            usuario.Correo = usuarioDTO.Correo;
            Rol rol = new Rol();
            rol.Id = usuarioDTO.Rol.Id;
            rol.Nombre = usuarioDTO.Rol.Nombre;
            usuario.Rol = rol;
            return usuario;
        }
        private UsuarioDTO TransferirDatosEntidad(Usuario usuario)
        {
            UsuarioDTO usuarioDTO = new UsuarioDTO();
            usuarioDTO.Id  = usuario.Id;
            usuarioDTO.Correo = usuario.Correo;
            RolDTO rolDTO = new RolDTO();
            rolDTO.Id = usuario.Rol.Id;
            rolDTO.Nombre = usuario.Rol.Nombre;
            usuarioDTO.Rol = rolDTO;
            return usuarioDTO;
        }
    }
}