﻿// <auto-generated />
using System;
using Locacao.Infra.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Locacao.Migrations
{
    [DbContext(typeof(EntityContext))]
    partial class EntityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Locacao.Agencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UF")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Agencia");
                });

            modelBuilder.Entity("Locacao.Aluguel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataDevolucao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataRetirada")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdAgenciaRetirada")
                        .HasColumnType("int");

                    b.Property<int>("IdDevolucao")
                        .HasColumnType("int");

                    b.Property<int>("IdDevolucaoVeiculo")
                        .HasColumnType("int");

                    b.Property<int>("IdRetirada")
                        .HasColumnType("int");

                    b.Property<bool>("LocacaoAtiva")
                        .HasColumnType("bit");

                    b.Property<int?>("LocalDevolucaoId")
                        .HasColumnType("int");

                    b.Property<double>("TotalDiariasLocacao")
                        .HasColumnType("float");

                    b.Property<double>("ValorTotal")
                        .HasColumnType("float");

                    b.Property<int?>("VeiculoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("LocalDevolucaoId");

                    b.HasIndex("VeiculoId");

                    b.ToTable("Aluguel");
                });

            modelBuilder.Entity("Locacao.CheckList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Amassado")
                        .HasColumnType("bit");

                    b.Property<bool>("Arranhoes")
                        .HasColumnType("bit");

                    b.Property<bool>("CarroLimpo")
                        .HasColumnType("bit");

                    b.Property<bool>("TanqueCheio")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("CheckLists");
                });

            modelBuilder.Entity("Locacao.DevolucaoVeiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdAluguel")
                        .HasColumnType("int");

                    b.Property<int>("IdCheckListDevolucao")
                        .HasColumnType("int");

                    b.Property<int>("IdOperador")
                        .HasColumnType("int");

                    b.Property<double>("SubTotal")
                        .HasColumnType("float");

                    b.Property<double>("ValorAdicional")
                        .HasColumnType("float");

                    b.Property<double>("ValorTotalPagar")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Devolucao");
                });

            modelBuilder.Entity("Locacao.Domain.Entities.Usuarios.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Data_nasc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UF")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Locacao.Domain.Entities.Usuarios.Operador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Matricula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Operadores");
                });

            modelBuilder.Entity("Locacao.Domain.Entities.Veiculo.MarcaVeiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MarcaVeiculo");
                });

            modelBuilder.Entity("Locacao.Domain.Entities.Veiculo.ModeloVeiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ModeloVeiculo");
                });

            modelBuilder.Entity("Locacao.Domain.Entities.Veiculo.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<int>("CapacidadePortaMalas")
                        .HasColumnType("int");

                    b.Property<int>("CapacidadeTanqueCombustivel")
                        .HasColumnType("int");

                    b.Property<bool>("CarroDisponivel")
                        .HasColumnType("bit");

                    b.Property<string>("FotoVeiculo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdAgencia")
                        .HasColumnType("int");

                    b.Property<int>("IdMarca")
                        .HasColumnType("int");

                    b.Property<int>("IdModelo")
                        .HasColumnType("int");

                    b.Property<string>("Placa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ValorDiaria")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Veiculo");
                });

            modelBuilder.Entity("Locacao.RetiradaVeiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdAluguel")
                        .HasColumnType("int");

                    b.Property<int>("IdCheckListRetirada")
                        .HasColumnType("int");

                    b.Property<int>("IdOperador")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Retirada");
                });

            modelBuilder.Entity("Locacao.Aluguel", b =>
                {
                    b.HasOne("Locacao.Domain.Entities.Usuarios.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("Locacao.Agencia", "LocalDevolucao")
                        .WithMany()
                        .HasForeignKey("LocalDevolucaoId");

                    b.HasOne("Locacao.Domain.Entities.Veiculo.Veiculo", "Veiculo")
                        .WithMany()
                        .HasForeignKey("VeiculoId");

                    b.Navigation("Cliente");

                    b.Navigation("LocalDevolucao");

                    b.Navigation("Veiculo");
                });
#pragma warning restore 612, 618
        }
    }
}
