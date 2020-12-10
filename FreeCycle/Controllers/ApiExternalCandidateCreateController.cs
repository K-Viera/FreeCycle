using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EdinsaWebServer.Models.Trabajo.Personas;
using EdinsaWebServer.ViewModels;
using FreeCycle.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EdinsaWebServer.Areas.Trabajo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiExternalCandidateCreateController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public ApiExternalCandidateCreateController(DatabaseContext contex)
        {
            _context = contex;
        }
        [HttpGet]
        public async Task<string> get(CandidateExternalCreateViewModel candidato)
        {
            return "hola";
        }
            [HttpPost]
        public async Task<string> Create(CandidateExternalCreateViewModel candidato) 
        {
            DatosGeneralesPersona datosGenerales = new DatosGeneralesPersona 
            {
                TipoIdentificacion = candidato.datosGeneralesPersona.TipoIdentificacion,
                NumeroIdentificacion = candidato.datosGeneralesPersona.NumeroIdentificacion,
                PrimerNombre = candidato.datosGeneralesPersona.PrimerNombre,
                SegundoNombre = candidato.datosGeneralesPersona.SegundoNombre,
                PrimerApellido = candidato.datosGeneralesPersona.PrimerApellido,
                SegundoApellido = candidato.datosGeneralesPersona.SegundoApellido,
                Genero = candidato.datosGeneralesPersona.Genero,
                Profesion = candidato.datosGeneralesPersona.Profesion,
                AnhosExperiencia = candidato.datosGeneralesPersona.AnhosExperiencia,
                MesesExperiencia = candidato.datosGeneralesPersona.MesesExperiencia,
                FechaNacimiento = candidato.datosGeneralesPersona.FechaNacimiento,
                Telefono = candidato.datosGeneralesPersona.Telefono,
                Celular = candidato.datosGeneralesPersona.Celular,
                Departamento = candidato.datosGeneralesPersona.Departamento,
                Direccion = candidato.datosGeneralesPersona.Direccion,
                Ciudad = candidato.datosGeneralesPersona.Ciudad,
                Email = candidato.datosGeneralesPersona.Email,
                Barrio = candidato.datosGeneralesPersona.Barrio,
                PersonaContactoNombre = candidato.datosGeneralesPersona.PersonaContactoNombre,
                PersonaContactoTelefono = candidato.datosGeneralesPersona.PersonaContactoTelefono,
                origenCandidato=ViewModels.Enums.OrigenCandidatoEnum.ApiPendiente
            };
            _context.datosGeneralesPersonas.Add(datosGenerales);
            await _context.SaveChangesAsync();

            DatosEspecificosPersona datosEspecificos = new DatosEspecificosPersona 
            {
                Id = datosGenerales.Id,
                Pais = candidato.datosEspecificosPersona.Pais,
                EstadoCivil = candidato.datosEspecificosPersona.EstadoCivil,
                ClaseLibretaMilitar = candidato.datosEspecificosPersona.ClaseLibretaMilitar,
                PaseDeConduccionTiene = candidato.datosEspecificosPersona.PaseDeConduccionTiene,
                PaseDeConduccionCategoriaA = candidato.datosEspecificosPersona.PaseDeConduccionCategoriaA,
                PaseDeConduccionCategoriaB = candidato.datosEspecificosPersona.PaseDeConduccionCategoriaB,
                PaseDeConduccionCategoriaC = candidato.datosEspecificosPersona.PaseDeConduccionCategoriaC,
                VehiculoTiene = candidato.datosEspecificosPersona.VehiculoTiene,
                TipoVehiculo = candidato.datosEspecificosPersona.TipoVehiculo,
                SeguridadSocialEPS = candidato.datosEspecificosPersona.SeguridadSocialEPS,
                SeguridadSocialNumeroDeBeneficiaros = candidato.datosEspecificosPersona.SeguridadSocialNumeroDeBeneficiaros
            };
            _context.datosEspecificosPersonas.Add(datosEspecificos);

            await _context.SaveChangesAsync();

            if (candidato.estudiosPersona.Count() > 0)
            {
                _context.datosAcademicosPersonas.Add(new DatosAcademicosPersona { Id = datosGenerales.Id });
                foreach (var estudioPersona in candidato.estudiosPersona)
                {
                    _context.estudioPersonas.Add(new EstudioPersona 
                    {
                        DatosAcademicosPersonaID = datosGenerales.Id,
                        NivelEstudio = estudioPersona.NivelEstudio,
                        InstitucionAcademica = estudioPersona.InstitucionAcademica,
                        ProgramaAcademico = estudioPersona.ProgramaAcademico,
                        AñoTerminacion = estudioPersona.AñoTerminacion,
                        PeriodosAprobados = estudioPersona.PeriodosAprobados,
                        Finalizo = estudioPersona.Finalizo
                    });
                }
                await _context.SaveChangesAsync();
                
                foreach (var datosLaborales in candidato.datosLaboralesPersona)
                {
                    _context.datosLaboralesPersonas.Add(new DatosLaboralesPersona 
                    {
                        DatosGeneralesPersonaId = datosGenerales.Id,
                        NombreEmpresa = datosLaborales.NombreEmpresa,
                        NombreTemporal = datosLaborales.NombreTemporal,
                        CargoDesempeñado = datosLaborales.CargoDesempeñado,
                        FechaInicio = datosLaborales.FechaInicio,
                        FechaRetiro = datosLaborales.FechaRetiro,
                        MotivoRetiro = datosLaborales.MotivoRetiro,
                        TrabajoActual = datosLaborales.TrabajoActual
                    });
                }
                await _context.SaveChangesAsync();
            }

            return "ok";
        }
    }
}
