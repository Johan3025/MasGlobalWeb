using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebMasGlobal.Models;

namespace WebMasGlobal.Models
{
    public class WebMasGlobalContext : DbContext
    {
        public WebMasGlobalContext (DbContextOptions<WebMasGlobalContext> options)
            : base(options)
        {
        }

        public DbSet<Employees> Employees { get; set; }

        public DbSet<WebMasGlobal.Models.Estudiante> Estudiante { get; set; }
    }
}
