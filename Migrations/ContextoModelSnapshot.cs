﻿// <auto-generated />
using FirebirdSql.EntityFrameworkCore.Firebird.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PostoInformatica_ERP.Models;

#nullable disable

namespace PostoInformatica_ERP.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Fb:ValueGenerationStrategy", FbValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 31);

            modelBuilder.Entity("PostoInformatica_ERP.Models.CLIENTES", b =>
                {
                    b.Property<string>("CNPJ_CPF")
                        .HasColumnType("VARCHAR(256)")
                        .HasColumnName("CNPJ_CPF");

                    b.Property<int>("CODIGO")
                        .HasColumnType("INTEGER")
                        .HasColumnName("CLIENTES");

                    b.HasKey("CNPJ_CPF");

                    b.ToTable("CLIENTES");
                });
#pragma warning restore 612, 618
        }
    }
}
