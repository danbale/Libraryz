namespace SSUABC.Models.EntidadesSolicitud
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Recurso")]
    public partial class Recurso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Recurso()
        {
            Solicituds = new HashSet<Solicitud>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Hospedaje { get; set; }

        public int? Transporte { get; set; }

        public bool? Combustible { get; set; }

        public bool? Viatico { get; set; }

        public bool? Oficio_Comision { get; set; }

        public bool? Otro { get; set; }

        [StringLength(100)]
        public string Descripcion_Otro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Solicitud> Solicituds { get; set; }
    }
}
