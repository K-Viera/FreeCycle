
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EdinsaWebServer.Models.Trabajo.Personas
{
    public class DatosLaboralesPersona:BaseModel
    {
        //Relacion *-1 con datos generales
        [ForeignKey("DatosGeneralesPersona")]
        public long DatosGeneralesPersonaId { get; set; }
        public virtual DatosGeneralesPersona DatosGeneralesPersona { get; set; }

        [Display(Name = "Nombre Empresa")]
        [Required(ErrorMessage = "Digite Nombre de la Empresa")]
        public string NombreEmpresa { get; set; }

        [Display(Name = "Nombre de la Temporal")]
        public string NombreTemporal { get; set; }

        [Display(Name = "Ciudad")]
        public string? Ciudad { get; set; }

        [Display(Name = "Cargo Desempeñado")]
        [Required(ErrorMessage = "Digite Cargo Desempeñado")]
        public string CargoDesempeñado { get; set; }

        [Display(Name = "Nombre Jefe")]
        public string? NombreJefe { get; set; }

        [Display(Name = "Cargo Jefe")]
        public string? CargoJefe { get; set; }

        [Display(Name = "Telefóno Jefe")]
        public string? TelefonoJefe { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        [Display(Name = "Fecha Inicio")]
        [Required(ErrorMessage = "Digite Fecha de Inicio")]
        public DateTime FechaInicio { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        [Display(Name = "Fecha Retiro")]
        public DateTime? FechaRetiro { get; set; }

        [Display(Name = "Motivo del Retiro")]
        public string MotivoRetiro { get; set; }

        public double? Salario { get; set; }

        [Display(Name = "Trabajo Actual")]
        [Required]
        public bool TrabajoActual { get; set; }


        [Display(Name = "Empresa Temporal")]
        [NotMapped]
        [Required]
        public bool EmpresaTemporal { get; set; }
    }
}
