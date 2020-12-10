using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EdinsaWebServer.ViewModels.Enums
{
    public enum TipoActividadEnum : int
    {
        Cargue = 1,
        [Display(Name = "Cargue Complejo")]
        CargueComplejo = 2,
        Descargue = 3,
        [Display(Name = "Descargue Complejo")]
        DescargueComplejo = 4,
        Otro = 99
    }
}
