namespace SSUABC.Models.EntidadesSolicitud
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            Carreras = new HashSet<Carrera>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Correo { get; set; }

        public int Id_Rol { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Carrera> Carreras { get; set; }

         [ForeignKey("Id_Rol")]
        public virtual Rol Rol { get; set; }
    }
}
