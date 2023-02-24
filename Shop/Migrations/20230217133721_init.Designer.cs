﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shop;

namespace Shop.Migrations
{
    [DbContext(typeof(ShopContext))]
    [Migration("20230217133721_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Shop.Models.Customer", b =>
                {
                    b.Property<string>("Address1")
                        .HasColumnName("Address1")
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<string>("Address2")
                        .HasColumnName("Address2")
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<string>("CreditLimit")
                        .IsRequired()
                        .HasColumnName("CreditLimit")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("CustomerName")
                        .HasColumnName("CustomerName")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("Phone")
                        .HasColumnName("Phone")
                        .HasColumnType("NVARCHAR(12)");

                    b.Property<string>("Status")
                        .HasColumnName("Status")
                        .HasColumnType("NVARCHAR(20)");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Shop.Models.SalesOrders", b =>
                {
                    b.Property<int>("OrderNbr")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("OrderNbr")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnName("Address")
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<int>("Amount")
                        .HasColumnName("Amount")
                        .HasColumnType("int");

                    b.Property<string>("CustomerName")
                        .HasColumnName("Customer")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("Description")
                        .HasColumnName("Description")
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<string>("ItemCode")
                        .HasColumnName("ItemCode")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<int>("Price")
                        .HasColumnName("Price")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnName("Quantitiy")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnName("Date")
                        .HasColumnType("DATE");

                    b.HasKey("OrderNbr");

                    b.ToTable("SalesOrders");
                });

            modelBuilder.Entity("Shop.Product", b =>
                {
                    b.Property<string>("ItemCode")
                        .HasColumnName("ItemCode")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<int>("Cost")
                        .HasColumnName("Cost")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnName("Description")
                        .HasColumnType("NVARCHAR(50");

                    b.Property<string>("ItemType")
                        .HasColumnName("ItemType")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<int>("Price")
                        .HasColumnName("Price")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnName("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ItemCode");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}