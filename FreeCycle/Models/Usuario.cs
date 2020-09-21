using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace FreeCycle.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public String Password { get; set; }

        [Required]
        public long PhoneNumber { get; set; }





    }
}
