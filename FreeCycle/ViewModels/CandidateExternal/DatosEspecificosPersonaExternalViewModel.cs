using EdinsaWebServer.ViewModels.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EdinsaWebServer.ViewModels.CandidateExternal
{
    public class DatosEspecificosPersonaExternalViewModel
    {
        [Required]
        public string Pais { get; set; }

        [Required]
        public EstadoCivilEnum EstadoCivil { get; set; }

        [Required]
        public ClaseLibretaEnum ClaseLibretaMilitar { get; set; }

        [Required]
        public bool PaseDeConduccionTiene { get; set; }

        public PaseConduccionCategoriaAEnum? PaseDeConduccionCategoriaA { get; set; }

        public PaseConduccionCategoriaBCEnum? PaseDeConduccionCategoriaB { get; set; }

        public PaseConduccionCategoriaBCEnum? PaseDeConduccionCategoriaC { get; set; }

        [Required]
        public bool VehiculoTiene { get; set; }

        public TipoVehiculoEnum? TipoVehiculo { get; set; }

        [Required]
        public string SeguridadSocialEPS { get; set; }
        
        [Required]
        public int SeguridadSocialNumeroDeBeneficiaros { get; set; }
    }
}
