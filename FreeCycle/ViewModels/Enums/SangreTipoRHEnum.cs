using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EdinsaWebServer.ViewModels.Enums
{
    public enum SangreTipoRHEnum : int
    {
        [Display(Name = "+")]
        Positivo = 0,
        [Display(Name = "-")]
        Negativo = 1,
    }
}
