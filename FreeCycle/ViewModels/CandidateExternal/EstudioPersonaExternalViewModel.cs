using EdinsaWebServer.Models;
using EdinsaWebServer.ViewModels.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EdinsaWebServer.ViewModels.CandidateExternal
{
    public class EstudioPersonaExternalViewModel : BaseModel
    {
        [DisplayName("Nivel de Estudio")]
        [Required(ErrorMessage = "Seleccione un nivel de estudio")]
        public string NivelEstudio { get; set; }
    
        [DisplayName("Institución Acádemica")]
        [Required(ErrorMessage = "Digite una institución acádemica")]
        public string InstitucionAcademica { get; set; }

        [DisplayName("Programa Acádemico")]
        [Required(ErrorMessage = "Digite un programa acádemico")]
        public string ProgramaAcademico { get; set; }

        [DisplayName("Año Terminación")]

        public DateTime? AñoTerminacion { get; set; }

        [DisplayName("Periodos Aprobados")]
        public int? PeriodosAprobados { get; set; }

        [DisplayName("Finalizó")]
        public FinalizoEstudiosEnum Finalizo { get; set; }
    }
}
