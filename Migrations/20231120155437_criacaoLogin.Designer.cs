﻿// <auto-generated />
using System;
using FirebirdSql.EntityFrameworkCore.Firebird.Metadata;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PostoInformatica_ERP.Models;

#nullable disable

namespace PostoInformatica_ERP.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20231120155437_criacaoLogin")]
    partial class criacaoLogin
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("BAIRRO")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("BAIRRO");

                    b.Property<string>("BAIRRO_COBRANCA")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("BAIRRO_COBRANCA");

                    b.Property<string>("CAIXA_POSTAL")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("CAIXA_POSTAL");

                    b.Property<string>("CAIXA_POSTAL_COBRANCA")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("CAIXA_POSTAL_COBRANCA");

                    b.Property<string>("CELULAR")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("CELULAR");

                    b.Property<string>("CEP")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("CEP");

                    b.Property<string>("CIDADE")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("CIDADE");

                    b.Property<string>("CIDADE_COBRANCA")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("CIDADE_COBRANCA");

                    b.Property<string>("CIDADE_IBGE")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("CIDADE_IBGE");

                    b.Property<int>("CODIGO")
                        .HasColumnType("INTEGER")
                        .HasColumnName("CLIENTES");

                    b.Property<string>("COLIGADA")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("COLIGADA");

                    b.Property<string>("COMPLEMENTO")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("COMPLEMENTO");

                    b.Property<string>("COMPLEMENTO_COBRANCA")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("COMPLEMENTO_COBRANCA");

                    b.Property<string>("COND_PAGAMENTO")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("COND_PAGAMENTO");

                    b.Property<string>("CONTATO")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("CONTATO");

                    b.Property<string>("EMAIL")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("EMAIL");

                    b.Property<string>("ENDERECO")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("ENDERECO");

                    b.Property<string>("ENDERECO_COBRANCA")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("ENDERECO_COBRANCA");

                    b.Property<string>("ESTADO")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("ESTADO");

                    b.Property<string>("ESTADO_COBRANCA")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("ESTADO_COBRANCA");

                    b.Property<string>("FANTASIA")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("FANTASIA");

                    b.Property<string>("FONE")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("FONE");

                    b.Property<string>("FONE_RAMAL")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("FONE_RAMAL");

                    b.Property<string>("INSCRICAOMUNICIPAL")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("INSCRICAOMUNICIPAL");

                    b.Property<string>("INTERNET")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("INTERNET");

                    b.Property<string>("LOGIN")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("LOGIN");

                    b.Property<string>("NOME")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("NOME");

                    b.Property<int?>("NUMERO")
                        .HasColumnType("INTEGER")
                        .HasColumnName("NUMERO");

                    b.Property<int?>("NUMERO_COBRANCA")
                        .HasColumnType("INTEGER")
                        .HasColumnName("NUMERO_COBRANCA");

                    b.Property<string>("PAIS")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("PAIS");

                    b.Property<string>("RG_INSCRICAO")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("RG_INSCRICAO");

                    b.Property<string>("SENHA")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("SENHA");

                    b.HasKey("CNPJ_CPF");

                    b.ToTable("CLIENTES");
                });

            modelBuilder.Entity("PostoInformatica_ERP.Models.USUARIO", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("USUARIO")
                        .HasAnnotation("Fb:ValueGenerationStrategy", FbValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("CPF");

                    b.Property<string>("NOME")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("NOME");

                    b.Property<string>("SENHA")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("SENHA");

                    b.Property<string>("SENHA_EMAIL")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("SENHA_EMAIL");

                    b.Property<string>("USUARIO_EMAIL")
                        .HasColumnType("BLOB SUB_TYPE TEXT")
                        .HasColumnName("USUARIO_EMAIL");

                    b.HasKey("ID");

                    b.ToTable("USUARIO");
                });
#pragma warning restore 612, 618
        }
    }
}