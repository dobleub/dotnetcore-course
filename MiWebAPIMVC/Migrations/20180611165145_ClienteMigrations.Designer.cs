﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using MiWebAPIMVC.Data;
using System;

namespace MiWebAPIMVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180611165145_ClienteMigrations")]
    partial class ClienteMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("MiWebAPIMVC.Models.Cliente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Nombre");

                    b.HasKey("ID");

                    b.ToTable("Cliente");
                });

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