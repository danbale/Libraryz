using SSUABC.Repositorios;
using SSUABC.Models.EntidadesUsuarioFIAD;
using SSUABC.Models.EntidadesUsuarioUABC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SSUABC.Models.EntidadesSolicitud;
using SSUABC.Models.EntidadesSolicitud.DTOEntidadesSolicitud;

namespace SSUABC.Servicios
{
    
    public class SesionServicio
    {
        UsuarioUABCRepositorioImpl usuarioRepositorioUABC;
        UsuarioRepositorioImpl usuarioRepositorioSS;

        public SesionServicio()
        {
            usuarioRepositorioUABC = new UsuarioUABCRepositorioImpl();
 
            usuarioRepositorioSS= new UsuarioRepositorioImpl(new EntidadesSS());
        }


        public MensajeDTO InicioSesion(UsuarioDTO usuario)
        {
            MensajeDTO mensajeEstado = new MensajeDTO();
            Models.EntidadesUsuarioUABC.Usuario usuarioUABC = usuarioRepositorioUABC.BuscarUsuarioUABC(usuario.Correo);

            if (usuarioUABC != null)
            {
                if (usuario.Contrasenia.Equals(usuarioUABC.Contraseña))
                {
                    Models.EntidadesUsuarioFIAD.Usuario usuarioFIAD = usuarioRepositorioUABC.BuscarUsuarioFIAD(usuario.Correo);

                    if(usuarioFIAD != null)
                    {
                        Models.EntidadesSolicitud.Usuario usuarioSS = usuarioRepositorioSS.BuscarPorCorreo(usuario.Correo);

                        if(usuarioSS != null)
                        {
                            UsuarioDTO usuarioAdministrativo = new UsuarioDTO();
                            RolDTO rol = new RolDTO();
                            usuarioAdministrativo.Nombre = usuarioUABC.Nombre;
                            usuarioAdministrativo.Apellido = usuarioUABC.Apellido;
                            rol.Nombre = usuarioSS.Rol.Nombre;
                            usuarioAdministrativo.Rol = rol;
                            mensajeEstado.Respuesta.Add("Mensaje", "Se ha iniciado sesion como Administrativo");
                            mensajeEstado.Respuesta.Add("Entidad", usuarioAdministrativo);

                        }
                        else
                        {
                            UsuarioDTO usuarioProfesor = new UsuarioDTO();
                            usuarioProfesor.Nombre = usuarioUABC.Nombre;
                            usuarioProfesor.Apellido = usuarioUABC.Apellido;
                            mensajeEstado.Respuesta.Add("Mensaje", "Se ha iniciado sesion como Profesor");
                            mensajeEstado.Respuesta.Add("Entidad", usuarioProfesor);
                        }
                    }
                    else
                    {
                        mensajeEstado.Respuesta.Add(null, "El usuario no pertenece a la Facultad de Ingenieria, Arquitectura y Diseño");
                    }
                }
                else
                {
                    mensajeEstado.Respuesta.Add(null, "La contraseña introducida es incorrecta");
                }
            }
            else
            {
                mensajeEstado.Respuesta.Add(null, "El usuario no pertenece a el dominio de UABC");            }

            return mensajeEstado;
        }

    }
}