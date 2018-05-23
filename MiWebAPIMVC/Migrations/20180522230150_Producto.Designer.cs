﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using MiWebAPIMVC.Models;
using System;

namespace MiWebAPIMVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180522230150_Producto")]
    partial class Producto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("MiWebAPIMVC.Models.Producto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Categoria");

                    b.Property<string>("Nombre");

                    b.Property<int>("Precio");

                    b.HasKey("ID");

                    b.ToTable("Producto");
                });
#pragma warning restore 612, 618
        }
    }
}
