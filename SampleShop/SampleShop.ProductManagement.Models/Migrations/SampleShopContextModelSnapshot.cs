﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SampleShop.ProductManagement.Models.DatabaseContext;

namespace SampleShop.ProductManagement.Models.Migrations
{
    [DbContext(typeof(SampleShopContext))]
    partial class SampleShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        .HasColumnType("decimal(18,4)");

                    b.Property<int>("ProductFlagId")
                        .HasColumnType("int");

                    b.Property<int>("ProductSubCatecoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LinkedProductId");

                    b.HasIndex("LocalCurrencyId");

                    b.HasIndex("ManufactureCountryId");

                    b.HasIndex("ProductFlagId");

                    b.HasIndex("ProductSubCatecoryId");

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

            modelBuilder.Entity("SampleShop.ProductManagement.Models.DatabaseContext.SubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("IdentificationNumber")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("MainCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MainCategoryId");

                    b.ToTable("SubCategory");
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

                    b.HasOne("SampleShop.ProductManagement.Models.DatabaseContext.Flag", "ProductFlag")
                        .WithMany()
                        .HasForeignKey("ProductFlagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SampleShop.ProductManagement.Models.DatabaseContext.SubCategory", "ProductSubCatecory")
                        .WithMany()
                        .HasForeignKey("ProductSubCatecoryId")
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

            modelBuilder.Entity("SampleShop.ProductManagement.Models.DatabaseContext.SubCategory", b =>
                {
                    b.HasOne("SampleShop.ProductManagement.Models.DatabaseContext.Category", "MainCategory")
                        .WithMany()
                        .HasForeignKey("MainCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
