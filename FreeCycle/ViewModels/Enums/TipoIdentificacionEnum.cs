using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EdinsaWebServer.ViewModels.Enums
{
    public enum TipoIdentificacionEnum : int
    {
        [Display(Name = "Cédula de ciudadanía")]
        CC = 0,
        [Display(Name = "Cédula de extranjería")]
        CE = 1,
        [Display(Name = "Pasaporte")]
        PA = 2,
        [Display(Name = "Permiso Especial de Trabajo")]
        PET = 3,
        [Display(Name = "Número Único de Identificación Personal")]
        NUIP = 4,
        [Display(Name = "Número de Identificación Personal")]
        NIP = 5,
        [Display(Name = "Tarjeta de Identidad")]
        TI = 6

    }
}
