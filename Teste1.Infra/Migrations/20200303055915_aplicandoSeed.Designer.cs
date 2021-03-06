﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Teste1.Infra.Context;

namespace Teste1.Infra.Migrations
{
    [DbContext(typeof(TesteContext))]
    [Migration("20200303055915_aplicandoSeed")]
    partial class aplicandoSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Teste1.Domain.Entidades.Cidade", b =>
                {
                    b.Property<int>("COD_CIDADE")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("COD_ESTADO")
                        .HasColumnType("int");

                    b.Property<string>("NOME_CIDADE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("COD_CIDADE");

                    b.HasIndex("COD_ESTADO");

                    b.ToTable("Cidade");

                    b.HasData(
                        new
                        {
                            COD_CIDADE = 1,
                            COD_ESTADO = 1,
                            NOME_CIDADE = "Camp Grande"
                        },
                        new
                        {
                            COD_CIDADE = 2,
                            COD_ESTADO = 1,
                            NOME_CIDADE = "Corumbá"
                        },
                        new
                        {
                            COD_CIDADE = 3,
                            COD_ESTADO = 1,
                            NOME_CIDADE = "Dourados"
                        });
                });

            modelBuilder.Entity("Teste1.Domain.Entidades.Endereco", b =>
                {
                    b.Property<int>("COD_ENDERECO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BAIRRO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("COD_CIDADE")
                        .HasColumnType("int");

                    b.Property<string>("LOGRADOURO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NUMERO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("COD_ENDERECO");

                    b.HasIndex("COD_CIDADE");

                    b.ToTable("Endereco");

                    b.HasData(
                        new
                        {
                            COD_ENDERECO = 1,
                            COD_CIDADE = 1,
                            LOGRADOURO = "Centro",
                            NUMERO = "1"
                        },
                        new
                        {
                            COD_ENDERECO = 2,
                            COD_CIDADE = 1,
                            LOGRADOURO = "Bairro",
                            NUMERO = "2"
                        },
                        new
                        {
                            COD_ENDERECO = 3,
                            COD_CIDADE = 2,
                            LOGRADOURO = "Centro",
                            NUMERO = "1"
                        },
                        new
                        {
                            COD_ENDERECO = 4,
                            COD_CIDADE = 2,
                            LOGRADOURO = "Bairro",
                            NUMERO = "2"
                        },
                        new
                        {
                            COD_ENDERECO = 5,
                            COD_CIDADE = 3,
                            LOGRADOURO = "Centro",
                            NUMERO = "1"
                        },
                        new
                        {
                            COD_ENDERECO = 6,
                            COD_CIDADE = 3,
                            LOGRADOURO = "Bairro",
                            NUMERO = "2"
                        });
                });

            modelBuilder.Entity("Teste1.Domain.Entidades.Estado", b =>
                {
                    b.Property<int>("COD_ESTADO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ESTADO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("COD_ESTADO");

                    b.ToTable("Estado");

                    b.HasData(
                        new
                        {
                            COD_ESTADO = 1,
                            ESTADO = "Mato Grosso do Sul",
                            UF = "MS"
                        });
                });

            modelBuilder.Entity("Teste1.Domain.Entidades.Pessoa", b =>
                {
                    b.Property<int>("COD_PESSOA")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("COD_ENDERECO")
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMAIL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NASCIMENTO")
                        .HasColumnType("datetime2");

                    b.Property<string>("NOME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TELEFONE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("COD_PESSOA");

                    b.HasIndex("COD_ENDERECO");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("Teste1.Domain.Entidades.Cidade", b =>
                {
                    b.HasOne("Teste1.Domain.Entidades.Estado", "ESTADO")
                        .WithMany("CIDADES")
                        .HasForeignKey("COD_ESTADO")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Teste1.Domain.Entidades.Endereco", b =>
                {
                    b.HasOne("Teste1.Domain.Entidades.Cidade", "CIDADE")
                        .WithMany("Enderecos")
                        .HasForeignKey("COD_CIDADE")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Teste1.Domain.Entidades.Pessoa", b =>
                {
                    b.HasOne("Teste1.Domain.Entidades.Endereco", "ENDERECO")
                        .WithMany("Pessoas")
                        .HasForeignKey("COD_ENDERECO")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
