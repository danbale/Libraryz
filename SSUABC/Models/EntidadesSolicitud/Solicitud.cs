namespace SSUABC.Models.EntidadesSolicitud
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Solicitud")]
    public partial class Solicitud
    {
        public int Id { get; set; }

        [Required]
        public string Folio { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre_Solicitante { get; set; }

        public int Numero_Empleado { get; set; }

        public int Id_Categoria { get; set; }

        public int Id_Carrera { get; set; }

        public int Id_Evento { get; set; }

        public int Id_Recurso_Solicitado { get; set; }

        public int Id_Actividad { get; set; }

        public int Id_Validacion { get; set; }

        public int Id_Estado { get; set; }

        public DateTime Fecha_Creacion { get; set; }

        public DateTime Fecha_Modificacion { get; set; }

        [StringLength(50)]
        public string URL_Reporte { get; set; }

        public virtual Actividad_Asociada Actividad_Asociada { get; set; }

        public virtual Carrera Carrera { get; set; }

        public virtual Categoria Categoria { get; set; }

        public virtual Estado Estado { get; set; }

        public virtual Evento Evento { get; set; }

        public virtual Recurso Recurso { get; set; }

        public virtual Validacion Validacion { get; set; }
    }
}
