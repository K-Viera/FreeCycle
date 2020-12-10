using EdinsaWebServer.Models.Trabajo.Personas;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace FreeCycle.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) 
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<DatosAcademicosPersona> datosAcademicosPersonas { get; set; }
        public DbSet<DatosGeneralesPersona> datosGeneralesPersonas { get; set; }
        public DbSet<DatosEspecificosPersona> datosEspecificosPersonas { get; set; }
        public DbSet<DatosLaboralesPersona> datosLaboralesPersonas { get; set; }
        public DbSet<EstudioPersona> estudioPersonas { get; set; }

        public DbSet<IdiomaPersona> idiomaPersonas { get; set; }
       
    }
}
