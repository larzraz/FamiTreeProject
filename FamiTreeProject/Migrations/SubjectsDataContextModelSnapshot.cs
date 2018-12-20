﻿// <auto-generated />
using FamiTreeProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FamiTreeProject.Migrations
{
    [DbContext(typeof(SubjectsDataContext))]
    partial class SubjectsDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FamiTreeProject.Models.Subject", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name");

                    b.Property<int>("parent");

                    b.HasKey("id");

                    b.ToTable("Subjects");

                    b.HasData(
                        new { id = 1, name = "Hanna", parent = 0 },
                        new { id = 2, name = "Hanna", parent = 1 },
                        new { id = 3, name = "Henna", parent = 2 },
                        new { id = 4, name = "Jorah", parent = 2 }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
