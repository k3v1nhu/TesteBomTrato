using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TesteBomTrato.Models;

namespace TesteBomTrato.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { }

        public DbSet<Processo> Processos { get; set; }

         protected override void OnModelCreating(ModelBuilder builder)
         {
             builder.Entity<Processo>()
                .HasData(new List<Processo>(){
                    new Processo(1, 001, "1500,00", "Guttenber", "Kevin")
                });
         }
    }
}