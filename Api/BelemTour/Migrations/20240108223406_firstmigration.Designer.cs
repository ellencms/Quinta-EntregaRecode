﻿// <auto-generated />
using BelemTour.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BelemTour.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240108223406_firstmigration")]
    partial class firstmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BelemTour.Model.Destino", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("Categoria")
                        .HasColumnType("int")
                        .HasColumnName("categoria");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nome");

                    b.Property<int>("Tempo")
                        .HasColumnType("int")
                        .HasColumnName("tempo");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("valor");

                    b.HasKey("Id");

                    b.ToTable("destino");
                });
#pragma warning restore 612, 618
        }
    }
}
