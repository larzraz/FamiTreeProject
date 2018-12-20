using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamiTreeProject.Models
{
    public class SubjectsDataContext:DbContext
    {
        public SubjectsDataContext()
        {

        }
        private readonly string _connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=FamiTree;Trusted_Connection=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        public SubjectsDataContext(DbContextOptions<SubjectsDataContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<Subject> Subjects { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subject>().HasData(new Subject
            {
                id = 1,
                name = "Hanna",
                parent = 0,


            },
                  new Subject
                  {
                      id = 2,
                      name = "Hanna",
                      parent = 1,

                  },
                  new Subject
                  {
                      id = 3,
                      name = "Henna",
                      parent = 2,

                  },
                  new Subject
                  {
                      id = 4,
                      name = "Jorah",
                      parent = 2,
                  }); }
        public IEnumerable<Subject> GetSubjects()
        {
            Database.EnsureCreated();
            return Subjects.ToList();

          
        }
    }
}

