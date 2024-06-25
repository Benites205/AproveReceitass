﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using testandoBancodDo0.Context;

#nullable disable

namespace testandoBancodDo0.Data.Migrations
{
    [DbContext(typeof(AproveDbContext))]
    [Migration("20231205012238_CadastroReceita")]
    partial class CadastroReceita
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("testandoBancodDo0.Models.ReceitaModel", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("Descricao")
                        .HasColumnType("text");

                    b.Property<string>("IdUsuario")
                        .HasColumnType("text");

                    b.Property<string>("Ingredientes")
                        .HasColumnType("text");

                    b.Property<string>("Titulo")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Receita");
                });

            modelBuilder.Entity("testandoBancodDo0.Models.UsuarioModel", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("testandoBancodDo0.Models.ReceitaModel", b =>
                {
                    b.HasOne("testandoBancodDo0.Models.UsuarioModel", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario");

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
