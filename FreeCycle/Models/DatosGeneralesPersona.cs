
using EdinsaWebServer.ViewModels.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EdinsaWebServer.Models.Trabajo.Personas
{
    [Table("DatosGeneralesPersonas")]
    public class DatosGeneralesPersona : BaseModel
    {
        internal OrigenCandidatoEnum origenCandidato;

        [Display(Name = "Tipo de Identificación")]
        [Required(ErrorMessage = "Seleccione Tipo de Identificación")]
        public TipoIdentificacionEnum TipoIdentificacion { get; set; }

        [Display(Name = "Número de Identificación")]
        [Required(ErrorMessage = "Digite Número de Identificación")]
        public string NumeroIdentificacion { get; set; }

        [Display(Name = "Primer Nombre")]
        [Required(ErrorMessage = "Digite Primer Nombre")]
        public string PrimerNombre { get; set; }

        [Display(Name = "Segundo Nombre")]
        public string? SegundoNombre { get; set; }

        [Display(Name = "Primer Apellido")]
        [Required(ErrorMessage = "Digite Primer Apellido")]
        public string PrimerApellido { get; set; }

        [Display(Name = "Segundo Apellido")]
        public string? SegundoApellido { get; set; }

        [Display(Name = "Género")]
        [Required(ErrorMessage = "Seleccione Género")]
        public GeneroEnum Genero { get; set; }

        [Display(Name = "Ocupación u Oficio")]
        [Required(ErrorMessage = "Digite Ocupación u Oficio")]
        public string Profesion { get; set; }

        [Display(Name = "Tiempo De Experiencia")]
        public int? AnhosExperiencia { get; set; }

        [Display(Name = "Meses de Experiencia")]
        public int? MesesExperiencia { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        [Required(ErrorMessage = "Digite Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Display(Name = "Telefóno")]
        public string? Telefono { get; set; }
        
        [Display(Name = "Celúlar")]
        public string? Celular { get; set; }

        [Display(Name = "Departamento")]
        [Required(ErrorMessage = "Seleccione Departamento")]
        public string Departamento { get; set; }
        
        [Display(Name = "Dirección")]
        [Required(ErrorMessage = "Digite Dirección")]
        public string Direccion { get; set; }

        [Display(Name = "Ciudad")]
        [Required(ErrorMessage = "Seleccione Ciudad")]
        public string Ciudad { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Digite Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite Nombre del Barrio")]
        public string Barrio { get; set; }

        [Display(Name = "Nombre Persona de Contacto")]
        public string? PersonaContactoNombre { get; set; }

        [Display(Name = "Telefóno Persona de Contacto")]
        public string? PersonaContactoTelefono { get; set; }

        public virtual DatosEspecificosPersona DatosEspecificos { get; set; }
        public virtual DatosAcademicosPersona DatosAcademicos { get; set; }

        [InverseProperty("DatosGeneralesPersona")]
        public virtual ICollection<DatosLaboralesPersona> DatosLaborales { get; set; }


        [Display(Name = "Nombre Completo")]
        public string NombreCompleto
        {
            get 
            {
                return $"{PrimerNombre} {SegundoNombre} {PrimerApellido} {SegundoApellido}".Trim();
            }
        }
    }
}
