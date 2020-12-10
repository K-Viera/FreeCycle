using EdinsaWebServer.ViewModels.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EdinsaWebServer.Models.Trabajo.Personas
{
    public class DatosAcademicosPersona : BaseModel
    {
        //Relacion 1-1 con datos generales
        [ ForeignKey("DatosGeneralesPersona")]
        public new long Id { get; set; }
        public virtual DatosGeneralesPersona DatosGeneralesPersona { get; set; }

        //Relacion 1-* con idioma persona
        [Display(Name = "Idioma")]
        [InverseProperty("DatosAcademicosPersona")]
        public virtual ICollection<IdiomaPersona> IdiomasPersona { get; set; }

        //relacion 1-* con estudios persona
        [InverseProperty("DatosAcademicosPersona")]
        public virtual ICollection<EstudioPersona> EstudiosPersona { get; set; }
    }
}
