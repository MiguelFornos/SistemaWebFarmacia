using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisFar.Datos.Model
{
    [Table("Cliente", Schema = "Catalogo")]
    public class Cliente
    {
        [Key]
        [Column("IdCliente")]
        [Required]
        public Guid IdCliente { get; set; }

        [Required]
        [Column("PrimerNombre")]
        [StringLength(200)]
        public string PrimerNombre { get; set; }

        [Required]
        [Column("SegundoNombre")]
        [StringLength(200)]
        public string SegundoNombre { get; set; }

        [Required]
        [Column("PrimerApellido")]
        [StringLength(200)]
        public string PrimerApellido { get; set; }

        [Required]
        [Column("SegundoApellido")]
        [StringLength(200)]
        public string SegundoApellido { get; set; }

        [Required]
        [Column("Edad")]
        public int Edad { get; set; }

        [Required]
        [Column("FechaRegistro")]
        public DateTime FechaRegistro { get; set; }

        [Required]
        [Column("EsActivo")]
        public bool EsActivo { get; set; }



    }
}
