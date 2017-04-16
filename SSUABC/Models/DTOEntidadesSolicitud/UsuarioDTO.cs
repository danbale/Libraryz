namespace SSUABC.Models.EntidadesSolicitud
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

  
    public partial class UsuarioDTO
    {
   
        public UsuarioDTO()
        {
        }

        public int Id { get; set; }

        public string Correo { get; set; }

        public RolDTO Rol { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Contrasenia { get; set; }

        public int Numero_Empleado { get; set; }


    }
}
