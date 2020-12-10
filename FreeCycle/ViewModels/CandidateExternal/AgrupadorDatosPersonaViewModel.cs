using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdinsaWebServer.ViewModels.CandidateExternal
{
    public class AgrupadorDatosPersonaViewModel
    {
       public DatosGeneralesPersonaExternalViewModel DatosGenerales {get;set;}
       public DatosEspecificosPersonaExternalViewModel DatosEspecificos { get;set;}
       public ICollection<DatosLaboralesExternalViewModel> DatosLaborales {get;set;}
       public ICollection<EstudioPersonaExternalViewModel> DatosAcademicos {get;set;}
    }
}
