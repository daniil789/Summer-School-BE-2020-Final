using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Summer_School_BE_2020_Final.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Game> Games {get;set;}
        public DbSet<Purchase> purchases { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
