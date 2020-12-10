using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EdinsaWebServer.ViewModels.Enums
{
    public enum PaseConduccionCategoriaAEnum : int
    {
        [Display(Name = "--Seleccione Clase--")]
        NoTiene = 0,
        [Display(Name = "Clase 1")]
        Categoria1 = 1,
        [Display(Name = "Clase 2")]
        Categoria2 = 2
    }
    public enum PaseConduccionCategoriaBCEnum : int
    {
        [Display(Name = "--Seleccione Clase--")]
        NoTiene = 0,
        [Display(Name = "Clase 1")]
        Categoria1 = 1,
        [Display(Name = "Clase 2")]
        Categoria2 = 2,
        [Display(Name = "Clase 3")]
        Categoria3 = 3
    }
}
