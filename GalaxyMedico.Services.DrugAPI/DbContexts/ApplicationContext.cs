using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GalaxyMedico.Services.DrugAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GalaxyMedico.Services.DrugAPI.DbContexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        {

        }
        public DbSet<Drug> Drugs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Drug>().HasData(
                new Drug
                {
                    DrugId=1,
                    Name="Combiflam",
                    CategoryName="Analgesic",
                    Description="Pain killer which has anti inflammtory property.",
                    Price=120.0,
                    ImageUrl= "https://galaxymdstore.blob.core.windows.net/galaxystore/Combiflam.png"
                });
            modelBuilder.Entity<Drug>().HasData(
               new Drug
               {
                   DrugId = 2,
                   Name = "Crocin",
                   CategoryName = "Antipyertic",
                   Description = "fever reducer which has analgesic property.",
                   Price = 80.0,
                   ImageUrl = "https://galaxymdstore.blob.core.windows.net/galaxystore/crocin.png"
               });
            modelBuilder.Entity<Drug>().HasData(
               new Drug
               {
                   DrugId = 3,
                   Name = "Gabapin NT",
                   CategoryName = "Nuero pain killer",
                   Description = "Nuero Pain killer which is good for ",
                   Price = 260.0,
                   ImageUrl = "https://galaxymdstore.blob.core.windows.net/galaxystore/Gabapin-NT.png"
               });

            modelBuilder.Entity<Drug>().HasData(
             new Drug
             {
                 DrugId = 4,
                 Name = "Amoxcyilin",
                 CategoryName = "Anti-Biotic",
                 Description = "treats cold, mumps",
                 Price = 150.0,
                 ImageUrl = "https://galaxymdstore.blob.core.windows.net/galaxystore/Amoxicillin.png"
             });

            modelBuilder.Entity<Drug>().HasData(
             new Drug
             {
                 DrugId = 5,
                 Name = "Allegra 120 Mg",
                 CategoryName = "Anti-Allergic",
                 Description = "Nuero Pain killer which is good for ",
                 Price = 260.0,
                 ImageUrl = "https://galaxymdstore.blob.core.windows.net/galaxystore/Allegra120.png"
             });
            modelBuilder.Entity<Drug>().HasData(
             new Drug
             {
                 DrugId = 6,
                 Name = "Amlokind AT",
                 CategoryName = "Type BP",
                 Description = "To treat blood pressure.",
                 Price = 25.0,
                 ImageUrl = "https://galaxymdstore.blob.core.windows.net/galaxystore/AmlokindAT.png"
             });
        }
    }
}
