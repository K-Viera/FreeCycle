using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EdinsaWebServer.ViewModels.Enums
{
    public enum NivelEstudioEnum :int
    {
        Bachillerato = 1,
        [Display(Name = "Técnico")]
        Tecnico = 2,
        [Display(Name = "Tecnólogo")]
        Tecnologo = 3,
        Universitario = 4,
        Otro = 5
    }
}
