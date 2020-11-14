﻿// <auto-generated />
using System;
using ArizaTakip.DataAccess.Concrete.EntitiyFrameworkCore.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ArizaTakip.DataAccess.Migrations
{
    [DbContext(typeof(ArizaTakipContext))]
    [Migration("20201024173616_arizacihazekleme")]
    partial class arizacihazekleme
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArizaTakip.Entites.Concrete.Ariza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArizaAciklama")
                        .HasColumnType("ntext");

                    b.Property<DateTime>("ArizaOlusturulmaTarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("ArizaTanim")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("CihazId")
                        .HasColumnType("int");

                    b.Property<string>("Durum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Ariza");
                });

            modelBuilder.Entity("ArizaTakip.Entites.Concrete.Cevap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArizaId")
                        .HasColumnType("int");

                    b.Property<string>("CevapAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cevap");
                });

            modelBuilder.Entity("ArizaTakip.Entites.Concrete.Cihaz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CihazAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CihazKayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("CihazTip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cihaz");
                });

            modelBuilder.Entity("ArizaTakip.Entites.Concrete.CihazOzellik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("COzellikDeger")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("COzellikTanim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CihazId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CihazOzellik");
                });

            modelBuilder.Entity("ArizaTakip.Entities.Concrete.Personel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("PerAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("PerBirim")
                        .HasColumnType("ntext");

                    b.Property<string>("PerUser")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personels");
                });
#pragma warning restore 612, 618
        }
    }
}
