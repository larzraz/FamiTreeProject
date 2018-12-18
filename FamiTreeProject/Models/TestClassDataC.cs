using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamiTreeProject.Models
{
    public class TestClassDataC:DbContext
    {
        public TestClassDataC()
        {

        }
        private readonly string _connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=FamiTree;Trusted_Connection=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        public TestClassDataC(DbContextOptions<TestClassDataC> options)
            : base(options)
        {
        }

        public virtual DbSet<TestClass> Subjects { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestClass>().HasData(new TestClass
            {
                id = 1,
                name = "Hanna",
                parent = 0,


            },
                  new TestClass
                  {
                      id = 2,
                      name = "Hanna",
                      parent = 1,

                  },
                  new TestClass
                  {
                      id = 3,
                      name = "Henna",
                      parent = 2,

                  },
                  new TestClass
                  {
                      id = 4,
                      name = "Jorah",
                      parent = 2,
                  }); }
        public IEnumerable<TestClass> GetTestClass()
        {
           
            return Subjects.ToList();
        }
    }
}

