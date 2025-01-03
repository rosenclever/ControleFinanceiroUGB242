﻿// <auto-generated />
using System;
using Apoio.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Apoio.Migrations
{
    [DbContext(typeof(WebetContext))]
    [Migration("20241029234459_saldo_apostador_nulo")]
    partial class saldo_apostador_nulo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Apoio.Models.Aposta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ApostadorId")
                        .HasColumnType("int");

                    b.Property<decimal>("PrevisaoDeGanho")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Vencedora")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ApostadorId");

                    b.ToTable("Apostas");
                });

            modelBuilder.Entity("Apoio.Models.Apostador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Saldo")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Apostadores");
                });

            modelBuilder.Entity("Apoio.Models.Aposta", b =>
                {
                    b.HasOne("Apoio.Models.Apostador", "Apostador")
                        .WithMany()
                        .HasForeignKey("ApostadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Apostador");
                });
#pragma warning restore 612, 618
        }
    }
}
