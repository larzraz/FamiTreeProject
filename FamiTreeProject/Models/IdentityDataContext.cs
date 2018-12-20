using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamiTreeProject.Models
{
    public class IdentityDataContext : IdentityDbContext<IdentityUser>
    {
        private readonly string _connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=FamiTree;Trusted_Connection=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
        public IdentityDataContext(DbContextOptions<IdentityDataContext> options)
            : base(options)
        {
            Database.EnsureCreated(); 
        }
    }
}
