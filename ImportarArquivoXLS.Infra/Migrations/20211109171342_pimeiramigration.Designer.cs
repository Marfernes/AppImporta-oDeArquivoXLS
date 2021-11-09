﻿// <auto-generated />
using System;
using ImportarArquivoXLS.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ImportarArquivoXLS.Infra.Migrations
{
    [DbContext(typeof(ImportarArquivoContext))]
    [Migration("20211109171342_pimeiramigration")]
    partial class pimeiramigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ImportarArquivoXLS.Domain.DadosDaPlanilha", b =>
                {
                    b.Property<Guid>("PagamentoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cessionario")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("CpfCnpjCessionario")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("nvarchar(18)");

                    b.Property<string>("Credor")
                        .IsRequired()
                        .HasMaxLength(8000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataAtualizacao")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentoCredor")
                        .IsRequired()
                        .HasMaxLength(8000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Finalidade")
                        .IsRequired()
                        .HasMaxLength(8000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Movimentacao")
                        .IsRequired()
                        .HasPrecision(18, 2)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroProcesso")
                        .IsRequired()
                        .HasMaxLength(8000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(8000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ValorPago")
                        .IsRequired()
                        .HasPrecision(18, 2)
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PagamentoID");

                    b.ToTable("DadosDaPlanilha");
                });
#pragma warning restore 612, 618
        }
    }
}
