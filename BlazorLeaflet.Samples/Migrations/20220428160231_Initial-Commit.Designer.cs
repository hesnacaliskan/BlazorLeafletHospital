﻿// <auto-generated />
using BlazorLeaflet.Samples.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorLeaflet.Samples.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20220428160231_Initial-Commit")]
    partial class InitialCommit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-preview.5.20278.2");

            modelBuilder.Entity("BlazorLeaflet.Samples.Data.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<double>("Latitude")
                        .HasColumnType("REAL");

                    b.Property<double>("Longitude")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1001,
                            Description = "This is a best gaming laptop",
                            Latitude = 0.0,
                            Longitude = 0.0,
                            Name = "Laptop",
                            Price = 20.02,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 1002,
                            Description = "This is a Office Application",
                            Latitude = 0.0,
                            Longitude = 0.0,
                            Name = "Microsoft Office",
                            Price = 20.989999999999998,
                            Quantity = 50
                        },
                        new
                        {
                            Id = 1003,
                            Description = "The mouse that works on all surface",
                            Latitude = 0.0,
                            Longitude = 0.0,
                            Name = "Lazer Mouse",
                            Price = 12.02,
                            Quantity = 20
                        },
                        new
                        {
                            Id = 1004,
                            Description = "To store 256GB of data",
                            Latitude = 0.0,
                            Longitude = 0.0,
                            Name = "USB Storage",
                            Price = 5.0,
                            Quantity = 20
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
