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
    [Migration("20240110185620_terceiramigration")]
    partial class terceiramigration
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

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("categoria");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("nome");

                    b.Property<string>("Tempo")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("tempo");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("valor");

                    b.HasKey("Id");

                    b.ToTable("destino");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Categoria = "Tur",
                            Nome = "Salinopolis",
                            Tempo = "5 Dias",
                            Valor = 200.00m
                        },
                        new
                        {
                            Id = 2,
                            Categoria = "Passeios Regulares",
                            Nome = "Mosqueiro",
                            Tempo = "1 semana",
                            Valor = 499.00m
                        },
                        new
                        {
                            Id = 3,
                            Categoria = "Passeios Regulares",
                            Nome = "Algodoal",
                            Tempo = "2 semana",
                            Valor = 900.00m
                        },
                        new
                        {
                            Id = 4,
                            Categoria = "Passeios Regulares",
                            Nome = "Marudá",
                            Tempo = "15 Dias",
                            Valor = 500.00m
                        },
                        new
                        {
                            Id = 5,
                            Categoria = "Passeios Regulares",
                            Nome = "Ajuruteua",
                            Tempo = "3 semana",
                            Valor = 1500.00m
                        },
                        new
                        {
                            Id = 6,
                            Categoria = "Tur",
                            Nome = "Outeiro",
                            Tempo = " 10 dias",
                            Valor = 400.00m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
