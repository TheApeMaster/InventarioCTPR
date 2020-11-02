using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Inventario.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() :base("con")
        {
        }

        public DbSet<Especialidad> Especialidad { get; set; }

        public DbSet<Bienes> Bienes { get; set; }
    }
}