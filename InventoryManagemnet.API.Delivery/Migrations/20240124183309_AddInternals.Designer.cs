﻿// <auto-generated />
using System;
using InventoryManagemnet.API.Delivery.INfrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InventoryManagemnet.API.Delivery.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240124183309_AddInternals")]
    partial class AddInternals
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InventoryManagemnet.API.Delivery.INfrastructure.Entities.InventoryItem", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("InventoryItems");

                    b.HasData(
                        new
                        {
                            ProductId = new Guid("2a1a2745-aae0-4625-b11b-5f18c03826bf"),
                            ProductName = "مثال محصول",
                            Quantity = 10
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
