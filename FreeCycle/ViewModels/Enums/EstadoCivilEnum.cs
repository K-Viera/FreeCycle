using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EdinsaWebServer.ViewModels.Enums
{
    public enum EstadoCivilEnum : int
    {
        [Display(Name = "Soltero(a)")]
        Soltero = 0,
        [Display(Name = "Casado(a)")]
        Casado = 1,
        [Display(Name = "Union Libre")]
        UnionLibre = 2,
        [Display(Name = "Divorciado(a)")]
        Divorciado = 3,
        [Display(Name = "Separado(a)")]
        Separado = 4,
        [Display(Name = "Viudo(a)")]
        Viudo = 5

    }
}
