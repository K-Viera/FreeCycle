using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EdinsaWebServer.ViewModels.Enums
{
    public enum ClaseLibretaEnum:int
    {
        [Display(Name = "No Tiene")]
        NoTiene = 0,
        Primera = 1,
        Segunda = 2
    }
}
