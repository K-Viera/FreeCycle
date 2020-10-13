﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FreeCycle.Models
{
    public class SolicitudDonacion
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String adress { get; set; }

        [Required]
        public String objeto { get; set; }

    }
}
