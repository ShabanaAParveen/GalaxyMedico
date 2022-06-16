﻿// <auto-generated />
using GalaxyMedico.Services.DrugAPI.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GalaxyMedico.Services.DrugAPI.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220528075532_SeedDrugs")]
    partial class SeedDrugs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GalaxyMedico.Services.DrugAPI.Models.Drug", b =>
                {
                    b.Property<int>("DrugId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("DrugId");

                    b.ToTable("Drugs");

                    b.HasData(
                        new
                        {
                            DrugId = 1,
                            CategoryName = "Analgesic",
                            Description = "Pain killer which has anti inflammtory property.",
                            ImageUrl = "https://galaxymdstore.blob.core.windows.net/galaxystore/Combiflam.png",
                            Name = "Combiflam",
                            Price = 120.0
                        },
                        new
                        {
                            DrugId = 2,
                            CategoryName = "Antipyertic",
                            Description = "fever reducer which has analgesic property.",
                            ImageUrl = "https://galaxymdstore.blob.core.windows.net/galaxystore/crocin.png",
                            Name = "Crocin",
                            Price = 80.0
                        },
                        new
                        {
                            DrugId = 3,
                            CategoryName = "Nuero pain killer",
                            Description = "Nuero Pain killer which is good for ",
                            ImageUrl = "https://galaxymdstore.blob.core.windows.net/galaxystore/Gabapin-NT.png",
                            Name = "Gabapin NT",
                            Price = 260.0
                        },
                        new
                        {
                            DrugId = 4,
                            CategoryName = "Anti-Biotic",
                            Description = "treats cold, mumps",
                            ImageUrl = "https://galaxymdstore.blob.core.windows.net/galaxystore/Amoxicillin.png",
                            Name = "Amoxcyilin",
                            Price = 150.0
                        },
                        new
                        {
                            DrugId = 5,
                            CategoryName = "Anti-Allergic",
                            Description = "Nuero Pain killer which is good for ",
                            ImageUrl = "https://galaxymdstore.blob.core.windows.net/galaxystore/Allegra120.png",
                            Name = "Allegra 120 Mg",
                            Price = 260.0
                        },
                        new
                        {
                            DrugId = 6,
                            CategoryName = "Type BP",
                            Description = "To treat blood pressure.",
                            ImageUrl = "https://galaxymdstore.blob.core.windows.net/galaxystore/AmlokindAT.png",
                            Name = "Amlokind AT",
                            Price = 25.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
