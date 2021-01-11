﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineStoreProject.Data;

namespace OnlineStoreProject.Migrations
{
    [DbContext(typeof(ProductsDbContext))]
    [Migration("20210111121146_ImagesWasAdded")]
    partial class ImagesWasAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineStoreProject.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<float>("Price");

                    b.Property<int>("QuantityInStoke");

                    b.HasKey("ID");

                    b.ToTable("Products");

                    b.HasData(
                        new { ID = 1, Description = "Big strong, but have no left eye", Image = "https://friendlystock.com/wp-content/uploads/2018/05/6-blue-dragon-cartoon-clipart.jpg", Name = "Woter Dragon", Price = 6000000f, QuantityInStoke = 3 },
                        new { ID = 2, Description = "Small, but magical", Image = "https://i.pinimg.com/originals/8f/99/83/8f99839632c9f2083b9a0592f5862a46.png", Name = "Dwarf", Price = 50000f, QuantityInStoke = 53 }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
