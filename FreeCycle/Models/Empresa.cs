using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FreeCycle.Models
{
    public class Empresa
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String CompanyName { get; set; }

        [Required]
        public String Password { get; set; }

        [Required]
        public String PhoneNumber { get; set; }

        [Required]
        public String Email { get; set; }

        [Required]
        public String NIT { get; set; }


    }
}
