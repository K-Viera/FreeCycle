using EdinsaWebServer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EdinsaWebServer.ViewModels.CandidateExternal
{
    public class DatosLaboralesExternalViewModel : BaseModel
    {
        [DisplayName("Nombre Empresa")]
        [Required]
        public string NombreEmpresa { get; set; }
        
        [DisplayName("Nombre Temporal")]
        public string? NombreTemporal { get; set; }

        [DisplayName("Cargo Desempeñado")]
        [Required(ErrorMessage = "Digite el cargo desempeñado")]
        public string CargoDesempeñado { get; set; }

        [DisplayName("Fecha Inicio")]
        [Required(ErrorMessage ="Digite la fecha de inicio")]
        public DateTime FechaInicio { get; set; }

        [DisplayName("Fecha Retiro")]
        public DateTime? FechaRetiro { get; set; }

        [DisplayName("Motivo Retiro")]
        public string? MotivoRetiro { get; set; }

        [DisplayName("Trabajo Actual")]
        [Required]
        public bool TrabajoActual { get; set; }

        [DisplayName("Empresa Temporal")] 
        [NotMapped]
        [Required]
        public bool EmpresaTemporal { get; set; }
    }
}
