using EdinsaWebServer.ViewModels.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EdinsaWebServer.Models.Trabajo.Personas
{
    public class EstudioPersona : BaseModel
    {
        [ForeignKey("DatosAcademicosPersona")]
        public long DatosAcademicosPersonaID { get; set; }
        public virtual DatosAcademicosPersona DatosAcademicosPersona { get; set; }

        [Display(Name = "Nivel de Estudio")]
        [Required(ErrorMessage = "Digite nivel de estudio")]
        public string NivelEstudio { get; set; }

        [Display(Name = "Institución Académica")]
        [Required(ErrorMessage = "Ingrese Institución Académica")]
        public string InstitucionAcademica { get; set; }

        [Display(Name = "Programa Académico")]
        [Required(ErrorMessage = "Ingrese Programa Académico")]
        public string ProgramaAcademico { get; set; }

        [Display(Name = "Ciudad")]
        public string Ciudad { get; set; }

        [Display(Name = "Año de Terminacíon")]
        public DateTime? AñoTerminacion { get; set; }

        [Display(Name = "Periodos Aprobados")]
        public int? PeriodosAprobados { get; set; }

        [Display(Name = "Finalizó Estudios")]
        [Required(ErrorMessage = "Seleccione un Estado")]
        public FinalizoEstudiosEnum Finalizo { get; set; }
    }
}
