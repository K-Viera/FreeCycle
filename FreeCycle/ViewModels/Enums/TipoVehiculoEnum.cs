using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EdinsaWebServer.ViewModels.Enums
{
    public enum TipoVehiculoEnum : int
    {
        [Display(Name = "--Seleccione TipoVehiculo--")]
        NoTiene = 0,
        Moto = 1,
        Carro = 2,
        [Display(Name ="Moto y Carro")]
        MotoCarro = 3
    }
}
