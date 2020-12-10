using EdinsaWebServer.ViewModels.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EdinsaWebServer.Models.Trabajo.Personas
{
    public class IdiomaPersona : BaseModel
    {

        [ForeignKey("DatosAcademicosPersona")]
        public long DatosAcademicosPersonaID { get; set; }
        public virtual DatosAcademicosPersona DatosAcademicosPersona { get; set; }

        public string Idioma { get; set; }
        [Display(Name = "Dominio Idioma")]
        public DominioIdiomaEnum DominioIdioma { get; set; }
    }
}
