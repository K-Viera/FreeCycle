using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EdinsaWebServer.ViewModels.Enums
{
    public enum PaisesListEnum : int
    {
        Colombia = 0,
        [Display(Name = "Otro / Cual")]
        Otro = 1
    }
}
