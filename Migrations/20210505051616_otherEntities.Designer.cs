﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesWebMVC.Models;

namespace SalesWebMVC.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20210505051616_otherEntities")]
    partial class otherEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SalesWebMVC.Models.Departaments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Departaments");
                });

            modelBuilder.Entity("SalesWebMVC.Models.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BaseSalary");

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<int?>("departamentsId");

                    b.HasKey("Id");

                    b.HasIndex("departamentsId");

                    b.ToTable("sellers");
                });

            modelBuilder.Entity("SalesWebMVC.Models.SellerRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<int>("Status");

                    b.Property<int?>("sellerId");

                    b.HasKey("Id");

                    b.HasIndex("sellerId");

                    b.ToTable("sellerRecords");
                });

            modelBuilder.Entity("SalesWebMVC.Models.Seller", b =>
                {
                    b.HasOne("SalesWebMVC.Models.Departaments", "departaments")
                        .WithMany("sellers")
                        .HasForeignKey("departamentsId");
                });

            modelBuilder.Entity("SalesWebMVC.Models.SellerRecord", b =>
                {
                    b.HasOne("SalesWebMVC.Models.Seller", "seller")
                        .WithMany("sales")
                        .HasForeignKey("sellerId");
                });
#pragma warning restore 612, 618
        }
    }
}