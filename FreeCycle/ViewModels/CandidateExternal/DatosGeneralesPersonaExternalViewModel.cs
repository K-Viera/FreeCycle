using EdinsaWebServer.ViewModels.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EdinsaWebServer.ViewModels.CandidateExternal
{
    public class DatosGeneralesPersonaExternalViewModel
    {
        [Required]
        public TipoIdentificacionEnum TipoIdentificacion { get; set; }
        
        [DisplayName("Número de Identificación")]
        [Required]
        public string NumeroIdentificacion { get; set; }

        //[Required(ErrorMessage = "Digite su Primer Nombre")]
        [DisplayName("Primer Nombre")]
        [Required]
        public string PrimerNombre { get; set; }

        public string? SegundoNombre { get; set; }

        //[Required(ErrorMessage = "Digite su Primer Apellido")]
        [DisplayName("Primer Primer Apellido")]
        [Required]
        public string PrimerApellido { get; set; }

        public string? SegundoApellido { get; set; }

        [Required]
        public GeneroEnum Genero { get; set; }

        //[Required(ErrorMessage = "Digite su Profesión")]
        [DisplayName("Profesión")]
        [Required]
        public string Profesion { get; set; }

        public int? AnhosExperiencia { get; set; }

        public int? MesesExperiencia { get; set; }

        //[Required(ErrorMessage = "Digite su Fecha de Nacimiento")]
        [DisplayName("Fecha de Nacimiento")]
        [Required]
        public DateTime FechaNacimiento { get; set; }

        [DisplayName("Telefóno")]
        public string? Telefono { get; set; }

        public string? Celular { get; set; }

        [Required]
        public string Departamento { get; set; }

        [DisplayName("Dirección")]
        [Required]
        public string Direccion { get; set; }
        
        [Required]
        public string Ciudad { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Barrio { get; set; }

        [DisplayName("Persona de Contacto")]
        public string? PersonaContactoNombre { get; set; }

        [DisplayName("Telefóno de el Contacto")]
        public string? PersonaContactoTelefono { get; set; }

    }
}
