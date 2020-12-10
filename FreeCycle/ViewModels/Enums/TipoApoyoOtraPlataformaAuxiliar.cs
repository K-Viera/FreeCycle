using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EdinsaWebServer.ViewModels.Enums
{
    public enum TipoApoyoOtraPlataformaAuxiliar : int
    {
        [Display(Name = "Hora Hombre")]
        HoraHombre = 0,
        [Display(Name = "Tipo de Vehículo")]
        TipoVehiculo = 1
    }
}
