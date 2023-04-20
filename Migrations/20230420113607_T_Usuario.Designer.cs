﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WIS___PI___v2.Data;

#nullable disable

namespace WIS___PI___v2.Migrations
{
    [DbContext(typeof(WIS___PI___v2Context))]
    [Migration("20230420113607_T_Usuario")]
    partial class T_Usuario
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WIS_PI.Models.Genero", b =>
                {
                    b.Property<int>("GeneroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GeneroId"));

                    b.Property<string>("NomeGenero")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GeneroId");

                    b.ToTable("Genero");
                });

            modelBuilder.Entity("WIS_PI.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("GeneroId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsuarioId");

                    b.HasIndex("GeneroId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("WIS_PI.Models.Usuario", b =>
                {
                    b.HasOne("WIS_PI.Models.Genero", "Genero")
                        .WithMany("Usuario")
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genero");
                });

            modelBuilder.Entity("WIS_PI.Models.Genero", b =>
                {
                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}