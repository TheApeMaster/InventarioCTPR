using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Inventario.Models
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Especialidad> Especialidad { get; set; }
        public DbSet<Bienes> Bienes { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties<string>().Where(p => p.Name.StartsWith("numeroDePatrimonio")).Configure(p => p.IsKey());

            modelBuilder.Entity<Bienes>().HasRequired(x => x.Especialidad);
           base.OnModelCreating(modelBuilder);     
        }
        public ApplicationDbContext() : base("con")
        {
        }


    }
}