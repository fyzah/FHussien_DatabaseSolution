using FHussien_DatabaseSolution.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FHussien_DatabaseSolution.Seed;

namespace FHussien_DatabaseSolution.Migrations
{
    public class FHussienDatabaseContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<UserInformation> UserInformations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\;Database=FHussienDatabase;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Data data = new Data();

            modelBuilder.Entity<Company>()
                .HasData(data.GetCompanies());
            modelBuilder.Entity<Role>()
                .HasData(data.GetRoles());
            modelBuilder.Entity<UserInformation>()
                .HasData(data.GetUserInformations());
            modelBuilder.Entity<User>()
                .HasData(data.GetUsers());
        }

    }
}
