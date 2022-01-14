﻿// <auto-generated />
using System;
using Cinema.WebApi.Infraestrutura;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cinema.WebApi.Migrations
{
    [DbContext(typeof(CinemaDbContext))]
    partial class CinemaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cinema.WebApi.Dominio.Filme", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataUltimaAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<int>("Duracao")
                        .HasColumnType("integer");

                    b.Property<string>("Sinopse")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Titulo")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Filmes");
                });

            modelBuilder.Entity("Cinema.WebApi.Dominio.Sessao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Ano")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataUltimaAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<int>("Dia")
                        .HasColumnType("integer");

                    b.Property<Guid>("FilmeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("HoraInicio")
                        .HasColumnType("integer");

                    b.Property<int>("Mes")
                        .HasColumnType("integer");

                    b.Property<int>("MinutoInicio")
                        .HasColumnType("integer");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.Property<int>("QuantidadeDisponivel")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeLugares")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Sessoes");
                });
#pragma warning restore 612, 618
        }
    }
}
