using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EdinsaWebServer.ViewModels.Enums
{
    public enum TipoAlertaEnum : int
    {
        [Display(Name = "Conductor no contesta la llamada")]
        ConductorNoContesta = 0,

        Otro = 99,
    }
}
