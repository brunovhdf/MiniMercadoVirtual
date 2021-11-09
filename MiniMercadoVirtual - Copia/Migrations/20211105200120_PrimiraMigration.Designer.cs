﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiniMercadoVirtual.Data;

namespace MiniMercadoVirtual.Migrations
{
    [DbContext(typeof(MiniMercadoVirtualContext))]
    [Migration("20211105200120_PrimiraMigration")]
    partial class PrimiraMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MiniMercadoVirtual.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DtAlteracao");

                    b.Property<DateTime>("DtInclusao");

                    b.Property<string>("Email");

                    b.Property<int?>("EnderecoId");

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("MiniMercadoVirtual.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro");

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<string>("Logradouro");

                    b.Property<string>("Numero");

                    b.Property<string>("Uf");

                    b.HasKey("Id");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("MiniMercadoVirtual.Models.Cliente", b =>
                {
                    b.HasOne("MiniMercadoVirtual.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");
                });
#pragma warning restore 612, 618
        }
    }
}
