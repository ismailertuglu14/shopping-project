﻿// <auto-generated />
using System;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinalProject.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20220605192217_supplier")]
    partial class supplier
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FinalProject.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Tişört"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Şort"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Gömlek"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Eşofman"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Pantolon"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Ceket"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Jeans"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryName = "Yelek"
                        },
                        new
                        {
                            CategoryId = 9,
                            CategoryName = "Kazak"
                        },
                        new
                        {
                            CategoryId = 10,
                            CategoryName = "Mont"
                        },
                        new
                        {
                            CategoryId = 11,
                            CategoryName = "Sweatshirt"
                        },
                        new
                        {
                            CategoryId = 12,
                            CategoryName = "Takım Elbise"
                        });
                });

            modelBuilder.Entity("FinalProject.Models.Colour", b =>
                {
                    b.Property<int>("ColourId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColourId"), 1L, 1);

                    b.Property<string>("ColourName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ColourId");

                    b.ToTable("Colours");

                    b.HasData(
                        new
                        {
                            ColourId = 1,
                            ColourName = "Blue"
                        },
                        new
                        {
                            ColourId = 2,
                            ColourName = "Red"
                        },
                        new
                        {
                            ColourId = 3,
                            ColourName = "Green"
                        },
                        new
                        {
                            ColourId = 4,
                            ColourName = "Brown"
                        },
                        new
                        {
                            ColourId = 5,
                            ColourName = "Purple"
                        },
                        new
                        {
                            ColourId = 6,
                            ColourName = "Black"
                        },
                        new
                        {
                            ColourId = 7,
                            ColourName = "Turquiose"
                        },
                        new
                        {
                            ColourId = 8,
                            ColourName = "Orange"
                        },
                        new
                        {
                            ColourId = 9,
                            ColourName = "Yellow"
                        },
                        new
                        {
                            ColourId = 10,
                            ColourName = "Pink"
                        },
                        new
                        {
                            ColourId = 11,
                            ColourName = "Gray"
                        },
                        new
                        {
                            ColourId = 12,
                            ColourName = "Beige"
                        },
                        new
                        {
                            ColourId = 13,
                            ColourName = "Khaki"
                        },
                        new
                        {
                            ColourId = 14,
                            ColourName = "Ecru"
                        },
                        new
                        {
                            ColourId = 15,
                            ColourName = "Navy Blue"
                        },
                        new
                        {
                            ColourId = 16,
                            ColourName = "Indigo"
                        });
                });

            modelBuilder.Entity("FinalProject.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ColourId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Supplier")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ColourId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            ColourId = 2,
                            Description = "Slim Fit Bisiklet Yaka Tişört",
                            ImagePath = "images/slimFit.jpg",
                            Price = 99.900000000000006,
                            ProductName = "Kısa Kollu Tişört",
                            Supplier = "Defacto"
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 2,
                            ColourId = 15,
                            Description = "Regular fit Basketbolcu Şort",
                            ImagePath = "images/slimFit.jpg",
                            Price = 105.98999999999999,
                            ProductName = "Şort",
                            Supplier = "Mavi"
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 3,
                            ColourId = 6,
                            Description = "Oversize Ekoseli Oduncu Gömliği",
                            ImagePath = "images/oduncugomlek.jpg",
                            Price = 176.99000000000001,
                            ProductName = "Oduncu Gömleği",
                            Supplier = "LCW"
                        });
                });

            modelBuilder.Entity("FinalProject.Models.Product", b =>
                {
                    b.HasOne("FinalProject.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalProject.Models.Colour", "Colour")
                        .WithMany()
                        .HasForeignKey("ColourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Colour");
                });
#pragma warning restore 612, 618
        }
    }
}