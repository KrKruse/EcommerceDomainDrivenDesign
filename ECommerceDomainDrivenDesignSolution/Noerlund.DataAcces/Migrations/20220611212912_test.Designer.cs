﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Noerlund.DataAcces.Contexts;

namespace Noerlund.DataAcces.Migrations
{
    [DbContext(typeof(NoerlundContext))]
    [Migration("20220611212912_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Noerlund.DataAcces.Models.CategoryDto", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("CategoryDtos");
                });

            modelBuilder.Entity("Noerlund.DataAcces.Models.CustomerDto", b =>
                {
                    b.Property<Guid>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CustomerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.ToTable("CustomerDtos");
                });

            modelBuilder.Entity("Noerlund.DataAcces.Models.OrderDto", b =>
                {
                    b.Property<Guid>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("OrderDtos");
                });

            modelBuilder.Entity("Noerlund.DataAcces.Models.OrderItemDto", b =>
                {
                    b.Property<Guid>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderItemId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItemDtosType");
                });

            modelBuilder.Entity("Noerlund.DataAcces.Models.ProductDto", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoryDtoCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<Guid?>("OrderItemDtoOrderItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryDtoCategoryId");

                    b.HasIndex("OrderItemDtoOrderItemId");

                    b.ToTable("ProductDtos");
                });

            modelBuilder.Entity("Noerlund.DataAcces.Models.OrderDto", b =>
                {
                    b.HasOne("Noerlund.DataAcces.Models.CustomerDto", "CustomerDto")
                        .WithMany("OrderDtos")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerDto");
                });

            modelBuilder.Entity("Noerlund.DataAcces.Models.OrderItemDto", b =>
                {
                    b.HasOne("Noerlund.DataAcces.Models.OrderDto", "OrderDto")
                        .WithMany("OrderItemDtos")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderDto");
                });

            modelBuilder.Entity("Noerlund.DataAcces.Models.ProductDto", b =>
                {
                    b.HasOne("Noerlund.DataAcces.Models.CategoryDto", "CategoryDto")
                        .WithMany("ProductDtos")
                        .HasForeignKey("CategoryDtoCategoryId");

                    b.HasOne("Noerlund.DataAcces.Models.OrderItemDto", null)
                        .WithMany("ProductDtos")
                        .HasForeignKey("OrderItemDtoOrderItemId");

                    b.Navigation("CategoryDto");
                });

            modelBuilder.Entity("Noerlund.DataAcces.Models.CategoryDto", b =>
                {
                    b.Navigation("ProductDtos");
                });

            modelBuilder.Entity("Noerlund.DataAcces.Models.CustomerDto", b =>
                {
                    b.Navigation("OrderDtos");
                });

            modelBuilder.Entity("Noerlund.DataAcces.Models.OrderDto", b =>
                {
                    b.Navigation("OrderItemDtos");
                });

            modelBuilder.Entity("Noerlund.DataAcces.Models.OrderItemDto", b =>
                {
                    b.Navigation("ProductDtos");
                });
#pragma warning restore 612, 618
        }
    }
}
