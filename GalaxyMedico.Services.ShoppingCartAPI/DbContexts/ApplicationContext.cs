using GalaxyMedico.Services.ShoppingCartAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalaxyMedico.Services.ShoppingCartAPI.DbContexts
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        {

        }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<CartHeader> CartHeaders { get; set; }

        public DbSet<CartDetails> CartDetails { get; set; }
    }
}
