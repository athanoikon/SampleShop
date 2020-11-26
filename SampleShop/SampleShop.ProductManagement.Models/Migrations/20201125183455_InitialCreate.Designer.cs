﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SampleShop.ProductManagement.Models.DatabaseContext;

namespace SampleShop.ProductManagement.Models.Migrations
{
    [DbContext(typeof(SampleShopContext))]
    [Migration("20201125183455_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SampleShop.ProductManagement.Models.DatabaseContext.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("HasSubCategory")
                        .HasColumnType("bit");

                    b.Property<Guid>("IdentificationNumber")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("SampleShop.ProductManagement.Models.DatabaseContext.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("SampleShop.ProductManagement.Models.DatabaseContext.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("Id");

                    b.ToTable("Currency");
                });

            modelBuilder.Entity("SampleShop.ProductManagement.Models.DatabaseContext.Flag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Flag");
                });

            modelBuilder.Entity("SampleShop.ProductManagement.Models.DatabaseContext.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LinkedProductId")
                        .HasColumnType("int");

                    b.Property<int>("LocalCurrencyId")
                        .HasColumnType("int");

                    b.Property<int>("ManufactureCountryId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductCatecoryId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ProductFlagId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LinkedProductId");

                    b.HasIndex("LocalCurrencyId");

                    b.HasIndex("ManufactureCountryId");

                    b.HasIndex("ProductCategoryId");

                    b.HasIndex("ProductFlagId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("SampleShop.ProductManagement.Models.DatabaseContext.PurchaseHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HistoryTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HistoryTypeId");

                    b.HasIndex("ProductId");

                    b.ToTable("PurchaseHistory");
                });

            modelBuilder.Entity("SampleShop.ProductManagement.Models.DatabaseContext.PurchaseHistoryType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PurchaseHistoryType");
                });

            modelBuilder.Entity("SampleShop.ProductManagement.Models.DatabaseContext.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserRole")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("SampleShop.ProductManagement.Models.DatabaseContext.Product", b =>
                {
                    b.HasOne("SampleShop.ProductManagement.Models.DatabaseContext.Product", "LinkedProduct")
                        .WithMany()
                        .HasForeignKey("LinkedProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SampleShop.ProductManagement.Models.DatabaseContext.Currency", "LocalCurrency")
                        .WithMany()
                        .HasForeignKey("LocalCurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SampleShop.ProductManagement.Models.DatabaseContext.Country", "ManufactureCountry")
                        .WithMany()
                        .HasForeignKey("ManufactureCountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SampleShop.ProductManagement.Models.DatabaseContext.Category", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("ProductCategoryId");

                    b.HasOne("SampleShop.ProductManagement.Models.DatabaseContext.Flag", "ProductFlag")
                        .WithMany()
                        .HasForeignKey("ProductFlagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SampleShop.ProductManagement.Models.DatabaseContext.PurchaseHistory", b =>
                {
                    b.HasOne("SampleShop.ProductManagement.Models.DatabaseContext.PurchaseHistoryType", "HistoryType")
                        .WithMany()
                        .HasForeignKey("HistoryTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SampleShop.ProductManagement.Models.DatabaseContext.Product", null)
                        .WithMany("Purchases")
                        .HasForeignKey("ProductId");
                });
#pragma warning restore 612, 618
        }
    }
}
