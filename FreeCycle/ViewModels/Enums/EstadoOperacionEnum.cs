using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EdinsaWebServer.ViewModels.Enums
{
    public enum EstadoOperacionEnum : int
    {
        Programado = 1,
        [Display(Name = "En Operación")]
        EnOperacion = 2,
        Detenido = 3,
        Terminado = 4,
        Cancelado = 5
    }
}
