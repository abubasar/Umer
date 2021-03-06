﻿// <auto-generated />
using System;
using Com.Umer.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Com.Umer.DataModel.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Com.Umer.DataModel.Brand", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Name");

                    b.Property<string>("Updated");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Com.Umer.DataModel.CartLine", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("OrderId");

                    b.Property<string>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<string>("Updated");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartLines");
                });

            modelBuilder.Entity("Com.Umer.DataModel.Category", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Name");

                    b.Property<string>("Updated");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Com.Umer.DataModel.Order", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Name");

                    b.Property<string>("PaymentId");

                    b.Property<bool>("Shipped");

                    b.Property<string>("Updated");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("PaymentId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Com.Umer.DataModel.Payment", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AuthCode");

                    b.Property<string>("CardExpiry");

                    b.Property<string>("CardNumber");

                    b.Property<int>("CardSecurityCode");

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedBy");

                    b.Property<decimal>("Total");

                    b.Property<string>("Updated");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Com.Umer.DataModel.Product", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrandId");

                    b.Property<string>("CategoryId");

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<string>("Updated");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Com.Umer.DataModel.Rating", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("ProductId");

                    b.Property<int>("Stars");

                    b.Property<string>("Updated");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("Com.Umer.DataModel.CartLine", b =>
                {
                    b.HasOne("Com.Umer.DataModel.Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderId");

                    b.HasOne("Com.Umer.DataModel.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("Com.Umer.DataModel.Order", b =>
                {
                    b.HasOne("Com.Umer.DataModel.Payment", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentId");
                });

            modelBuilder.Entity("Com.Umer.DataModel.Product", b =>
                {
                    b.HasOne("Com.Umer.DataModel.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId");

                    b.HasOne("Com.Umer.DataModel.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("Com.Umer.DataModel.Rating", b =>
                {
                    b.HasOne("Com.Umer.DataModel.Product", "Product")
                        .WithMany("Ratings")
                        .HasForeignKey("ProductId");
                });
#pragma warning restore 612, 618
        }
    }
}
