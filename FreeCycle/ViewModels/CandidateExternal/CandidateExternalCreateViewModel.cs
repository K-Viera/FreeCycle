using EdinsaWebServer.Models.Trabajo.Personas;
using EdinsaWebServer.ViewModels.CandidateExternal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdinsaWebServer.ViewModels
{
    public class CandidateExternalCreateViewModel
    {
        public DatosGeneralesPersonaExternalViewModel datosGeneralesPersona { get; set; }
        public DatosEspecificosPersonaExternalViewModel datosEspecificosPersona { get; set; }
        public ICollection<DatosLaboralesExternalViewModel> datosLaboralesPersona { get; set; }
        public ICollection<EstudioPersonaExternalViewModel> estudiosPersona { get; set; }
    }
}
