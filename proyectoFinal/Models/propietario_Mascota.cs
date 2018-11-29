namespace proyectoFinal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class propietario_Mascota
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public propietario_Mascota()
        {
            mascota = new HashSet<mascota>();
        }

        [Key]
        public int codpropietario { get; set; }

        [Required]
        [StringLength(100)]
        [RegularExpression("^[a-zA-Z]+?$", ErrorMessage = "Solo se permiten letras")]
        public string nombre { get; set; }

        [Required]
        [StringLength(100)]
        [RegularExpression("^[a-zA-Z]+?$", ErrorMessage = "Solo se permiten letras")]
        public string apellido { get; set; }

        [Required]
        [RegularExpression(@"^\(?([0-9]{8})\)?[-]([0-9]{1})$", ErrorMessage = "introduzca un numero valido")]
        [StringLength(10)]
        public string dui { get; set; }

        [Required]
        [StringLength(10)]
        public string sexo { get; set; }

        [Required]
        [RegularExpression(@"^\(?([0-9]{4})\)?[-]([0-9]{4})$", ErrorMessage = "introduzca un numero valido")]
        [StringLength(10)]
        public string telefono { get; set; }

        [Required]
        [StringLength(150)]
        public string direccion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mascota> mascota { get; set; }
    }
}
