using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FreeCycle.Models
{
    public class OfrecerDonacion
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String adress { get; set; }

        [Required]
        public String estado { get; set; }

        [Required]
        public String objeto { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
