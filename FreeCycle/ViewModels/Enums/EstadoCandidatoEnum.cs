using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EdinsaWebServer.ViewModels.Enums
{
    public enum EstadoCandidatoEnum: int
    {
        [Display(Name = "En Proceso")]
        proceso=0,
        [Display(Name = "Rechazado")]
        rechazado =1,
        [Display(Name = "Aceptado")]
        aceptado =2,
        [Display(Name = "Eliminar")]
        eliminado =3
    }
}
