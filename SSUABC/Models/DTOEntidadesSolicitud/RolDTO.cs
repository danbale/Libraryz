namespace SSUABC.Models.EntidadesSolicitud
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RolDTO
    {
    
        public int Id { get; set; }

        public string Nombre { get; set; }


    }
}
