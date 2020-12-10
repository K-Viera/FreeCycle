
using EdinsaWebServer.ViewModels.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EdinsaWebServer.Models.Trabajo.Personas
{
    [Table("DatosEspecificosPersonas")]
    public class DatosEspecificosPersona  : BaseModel
    {
        [Key, ForeignKey("DatosGeneralesPersona")]
        public new long Id { get; set; }

        public virtual DatosGeneralesPersona DatosGeneralesPersona { get; set; }

        [Display(Name = "Departamento de Expedición")]
        public string? DepartamentoExpedicionIdentificacion { get; set; }

        [Display(Name = "Ciudad de Expedición")]
        public string? CiudadExpedicionIdentificacion { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        [Display(Name = "Fecha de Expedición")]
        public DateTime? FechaExpedicionIdentificacion { get; set; }

        [Display(Name = "País de Nacimiento")]
        [Required(ErrorMessage = "Digite País de Nacimiento")]
        public string Pais { get; set; }

        [Display(Name = "Departamento de Nacimiento")]
        public string? Departamento { get; set; }

        [Display(Name = "Ciudad de Nacimiento")]
        public string? Ciudad { get; set; }

        [Display(Name = "Tipo de sangre")]
        public SangreTipoEnum? TipoDeSangre { get; set; }

        [Display(Name = "Factor RH")]
        public SangreTipoRHEnum? FactorRHSangre { get; set; }

        [Display(Name = "Estado Civil")]
        [Required]
        public EstadoCivilEnum EstadoCivil { get; set; }

        [Display(Name = "Numero de Libreta Militar")]
        public string? NumeroLibretaMilitar { get; set; }

        [Display(Name = "Clase de Libreta Militar")]
        [Required]
        public ClaseLibretaEnum ClaseLibretaMilitar { get; set; }

        [Display(Name = "Numero de Distrito Militar")]
        public string? NumeroDistritoMilitar { get; set; }

        [Display(Name = "Tiene Licencia de Conducción")]
        [Required]
        public bool PaseDeConduccionTiene { get; set; }

        public PaseConduccionCategoriaAEnum? PaseDeConduccionCategoriaA { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime? FechaVencecategoriaA { get; set; }

        public PaseConduccionCategoriaBCEnum? PaseDeConduccionCategoriaB { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime? FechaVencecategoriaB { get; set; }

        public PaseConduccionCategoriaBCEnum? PaseDeConduccionCategoriaC { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime? FechaVencecategoriaC { get; set; }

        [Display(Name = "Tiene Vehículo")]
        [Required]
        public bool VehiculoTiene { get; set; }

        [Display(Name = "Tipo Vehículo")]
        public TipoVehiculoEnum? TipoVehiculo { get; set; }

        [Display(Name = "Talla de Camisa")]
        public TallaCamisaEnum? TallaCamisa { get; set; }
        
        [Display(Name = "Talla de Pantalón")]
        public int? TallaPantalon { get; set; }

        [Display(Name = "Talla de Zapato")]
        public int? TallaZapato { get; set; }

        [Display(Name = "EPS")]
        [Required]
        public string SeguridadSocialEPS { get; set; }

        [Display(Name = "Fondo de Pensiones")]
        public string? SeguridadSocialFondoDePensiones { get; set; }

        [Display(Name = "Numero de Beneficiaros")]
        [Required]
        public int SeguridadSocialNumeroDeBeneficiaros { get; set; }

    }
}
