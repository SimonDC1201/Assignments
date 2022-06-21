﻿// <auto-generated />
using System;
using Assignment01.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assignment01.Migrations
{
    [DbContext(typeof(NorthwindContext))]
    [Migration("20220621041158_2nd")]
    partial class _2nd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Assignment01.Models.Category", b =>
                {
                    b.Property<long>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("CategoryID");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Assignment01.Models.Customer", b =>
                {
                    b.Property<long>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("CustomerID");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustomerName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .HasColumnType("TEXT");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Assignment01.Models.Employee", b =>
                {
                    b.Property<long>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("EmployeeID");

                    b.Property<byte[]>("BirthDate")
                        .HasColumnType("DATE");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Photo")
                        .HasColumnType("TEXT");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Assignment01.Models.Order", b =>
                {
                    b.Property<long>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("OrderID");

                    b.Property<long?>("CustomerId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("CustomerID");

                    b.Property<long?>("EmployeeId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("EmployeeID");

                    b.Property<byte[]>("OrderDate")
                        .HasColumnType("DATETIME");

                    b.Property<long?>("ShipperId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("ShipperID");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ShipperId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Assignment01.Models.OrderDetail", b =>
                {
                    b.Property<long>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("OrderDetailID");

                    b.Property<long?>("OrderId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("OrderID");

                    b.Property<long?>("ProductId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("ProductID");

                    b.Property<long?>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Assignment01.Models.Product", b =>
                {
                    b.Property<long>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("ProductID");

                    b.Property<long?>("CategoryId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("CategoryID");

                    b.Property<string>("ProductName")
                        .HasColumnType("TEXT");

                    b.Property<long?>("SupplierId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("SupplierID");

                    b.Property<string>("Unit")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("UnitPrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMERIC")
                        .HasDefaultValueSql("0");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Assignment01.Models.Shipper", b =>
                {
                    b.Property<long>("ShipperId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("ShipperID");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("ShipperName")
                        .HasColumnType("TEXT");

                    b.HasKey("ShipperId");

                    b.ToTable("Shippers");
                });

            modelBuilder.Entity("Assignment01.Models.Supplier", b =>
                {
                    b.Property<long>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("SupplierID");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("SupplierName")
                        .HasColumnType("TEXT");

                    b.HasKey("SupplierId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("Assignment01.Models.Order", b =>
                {
                    b.HasOne("Assignment01.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");

                    b.HasOne("Assignment01.Models.Employee", "Employee")
                        .WithMany("Orders")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("Assignment01.Models.Shipper", "Shipper")
                        .WithMany("Orders")
                        .HasForeignKey("ShipperId");

                    b.Navigation("Customer");

                    b.Navigation("Employee");

                    b.Navigation("Shipper");
                });

            modelBuilder.Entity("Assignment01.Models.OrderDetail", b =>
                {
                    b.HasOne("Assignment01.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId");

                    b.HasOne("Assignment01.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Assignment01.Models.Product", b =>
                {
                    b.HasOne("Assignment01.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.HasOne("Assignment01.Models.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId");

                    b.Navigation("Category");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Assignment01.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Assignment01.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Assignment01.Models.Employee", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Assignment01.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("Assignment01.Models.Product", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("Assignment01.Models.Shipper", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Assignment01.Models.Supplier", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
