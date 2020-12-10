using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EdinsaWebServer.ViewModels.Enums
{
    public enum TipoPagoEnum : int
    {
        Efectivo = 1,
        [Display(Name = "Crédito")]
        Credito = 2
    }
}
