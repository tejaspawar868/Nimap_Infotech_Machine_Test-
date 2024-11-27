using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NimapInfoMachineTest.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("dbcs")
        { 
        
        
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }


    }
}