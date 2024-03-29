﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OkulCodeFirst.Entities;

namespace OkulCodeFirst.Migrations.SqlServerDbcontextMigrations
{
    [DbContext(typeof(SqlServerDbcontext))]
    [Migration("20220509144227_initDb")]
    partial class initDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OkulCodeFirst.Entities.Adres", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cadde")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IlceId")
                        .HasColumnType("int");

                    b.Property<string>("KapiNo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("OgrenciId")
                        .HasColumnType("int");

                    b.Property<int?>("SehirId")
                        .HasColumnType("int");

                    b.Property<string>("Sokak")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IlceId");

                    b.HasIndex("OgrenciId");

                    b.HasIndex("SehirId");

                    b.ToTable("Adresler");
                });

            modelBuilder.Entity("OkulCodeFirst.Entities.Alan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlanAdi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AlanAdi")
                        .IsUnique()
                        .HasFilter("[AlanAdi] IS NOT NULL");

                    b.ToTable("Alanlar");

                    b.HasData(
                        new
                        {
                            Id = 10,
                            AlanAdi = "Sayisal",
                            CreateDate = new DateTime(2022, 5, 9, 17, 42, 26, 757, DateTimeKind.Local).AddTicks(5189),
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 11,
                            AlanAdi = "Sözel",
                            CreateDate = new DateTime(2022, 5, 9, 17, 42, 26, 758, DateTimeKind.Local).AddTicks(1599),
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 12,
                            AlanAdi = "Dil",
                            CreateDate = new DateTime(2022, 5, 9, 17, 42, 26, 758, DateTimeKind.Local).AddTicks(1612),
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 13,
                            AlanAdi = "Eşit Ağirlik",
                            CreateDate = new DateTime(2022, 5, 9, 17, 42, 26, 758, DateTimeKind.Local).AddTicks(1614),
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("OkulCodeFirst.Entities.Ilce", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("IlceAdi")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("SehirId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SehirId");

                    b.ToTable("Ilceler");
                });

            modelBuilder.Entity("OkulCodeFirst.Entities.Ogrenci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Cinsiyet")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gsm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SinifId")
                        .HasColumnType("int");

                    b.Property<string>("Soyadi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TcNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("SinifId");

                    b.ToTable("Ogrenciler");
                });

            modelBuilder.Entity("OkulCodeFirst.Entities.Sehir", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SehirAdi")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Sehirler");
                });

            modelBuilder.Entity("OkulCodeFirst.Entities.Sinif", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AlanId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<short>("Kapasite")
                        .HasColumnType("smallint");

                    b.Property<string>("SinifAdi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AlanId");

                    b.ToTable("Siniflar");

                    b.HasData(
                        new
                        {
                            Id = 10,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Kapasite = (short)40,
                            SinifAdi = "10A",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 11,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Kapasite = (short)40,
                            SinifAdi = "10B",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 12,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Kapasite = (short)40,
                            SinifAdi = "10C",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 13,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Kapasite = (short)40,
                            SinifAdi = "11A",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 14,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Kapasite = (short)40,
                            SinifAdi = "11B",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 15,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Kapasite = (short)40,
                            SinifAdi = "12C",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("OkulCodeFirst.Entities.Adres", b =>
                {
                    b.HasOne("OkulCodeFirst.Entities.Ilce", "Ilce")
                        .WithMany()
                        .HasForeignKey("IlceId");

                    b.HasOne("OkulCodeFirst.Entities.Ogrenci", null)
                        .WithMany("Adresler")
                        .HasForeignKey("OgrenciId");

                    b.HasOne("OkulCodeFirst.Entities.Sehir", "Sehir")
                        .WithMany()
                        .HasForeignKey("SehirId");

                    b.Navigation("Ilce");

                    b.Navigation("Sehir");
                });

            modelBuilder.Entity("OkulCodeFirst.Entities.Ilce", b =>
                {
                    b.HasOne("OkulCodeFirst.Entities.Sehir", "Sehir")
                        .WithMany("Ilce")
                        .HasForeignKey("SehirId");

                    b.Navigation("Sehir");
                });

            modelBuilder.Entity("OkulCodeFirst.Entities.Ogrenci", b =>
                {
                    b.HasOne("OkulCodeFirst.Entities.Sinif", "Sinif")
                        .WithMany()
                        .HasForeignKey("SinifId");

                    b.Navigation("Sinif");
                });

            modelBuilder.Entity("OkulCodeFirst.Entities.Sinif", b =>
                {
                    b.HasOne("OkulCodeFirst.Entities.Alan", "Alan")
                        .WithMany("Siniflar")
                        .HasForeignKey("AlanId");

                    b.Navigation("Alan");
                });

            modelBuilder.Entity("OkulCodeFirst.Entities.Alan", b =>
                {
                    b.Navigation("Siniflar");
                });

            modelBuilder.Entity("OkulCodeFirst.Entities.Ogrenci", b =>
                {
                    b.Navigation("Adresler");
                });

            modelBuilder.Entity("OkulCodeFirst.Entities.Sehir", b =>
                {
                    b.Navigation("Ilce");
                });
#pragma warning restore 612, 618
        }
    }
}
