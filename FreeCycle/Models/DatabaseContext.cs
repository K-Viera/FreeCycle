using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using FreeCycle.Models;

namespace FreeCycle.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) 
        {
        }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<FreeCycle.Models.Empresa> Empresa { get; set; }
        public DbSet<SolicitudDonacion> solicitudDonacion { get; set; }

        
       
       
    }
}
