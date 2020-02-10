using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SushiStore.Models;

namespace SushiStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Culture> Cultures { get; set; }
        public DbSet<Resource> Resources { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Culture>().HasAlternateKey(c => c.Name);
            modelBuilder.Entity<Resource>().Property(r => r.Key).IsRequired();
        }
    }
}
