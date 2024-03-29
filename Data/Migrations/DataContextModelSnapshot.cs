﻿// <auto-generated />
using System;
using LivrariaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace LivrariaAPI.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("LivrariaAPI.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Ativo")
                        .HasColumnType("integer");

                    b.Property<string>("Cargo")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = 1,
                            Cargo = "admin",
                            Email = "admin@admin.com",
                            Nome = "admin",
                            Password = "8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918",
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("LivrariaAPI.Models.Aluguel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("AluguelFeito")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("Devolucao")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("LivroId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("PrevisaoEntrega")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("LivroId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Alugueis");
                });

            modelBuilder.Entity("LivrariaAPI.Models.Editora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Cidade")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Editoras");
                });

            modelBuilder.Entity("LivrariaAPI.Models.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Autor")
                        .HasColumnType("text");

                    b.Property<int>("EditoraId")
                        .HasColumnType("integer");

                    b.Property<int>("Lancamento")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<int>("Quantidade")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EditoraId");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("LivrariaAPI.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Cidade")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Endereco")
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("LivrariaAPI.Models.Aluguel", b =>
                {
                    b.HasOne("LivrariaAPI.Models.Livro", "Livro")
                        .WithMany("Alugueis")
                        .HasForeignKey("LivroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LivrariaAPI.Models.Usuario", "Usuario")
                        .WithMany("Alugueis")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LivrariaAPI.Models.Livro", b =>
                {
                    b.HasOne("LivrariaAPI.Models.Editora", "Editora")
                        .WithMany("Livros")
                        .HasForeignKey("EditoraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
