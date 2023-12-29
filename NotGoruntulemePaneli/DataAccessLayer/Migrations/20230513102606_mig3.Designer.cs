﻿// <auto-generated />
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230513102606_mig3")]
    partial class mig3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.MeslekiInglizce", b =>
                {
                    b.Property<int>("MeslekiIngizceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Final")
                        .HasColumnType("int");

                    b.Property<string>("OgrAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OgretimUyesiID")
                        .HasColumnType("int");

                    b.Property<int>("Vize1")
                        .HasColumnType("int");

                    b.Property<int>("Vize2")
                        .HasColumnType("int");

                    b.HasKey("MeslekiIngizceID");

                    b.HasIndex("OgretimUyesiID");

                    b.ToTable("MeslekiInglizces");
                });

            modelBuilder.Entity("EntityLayer.OgretimUyesi", b =>
                {
                    b.Property<int>("OgretimUyesiID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DersID")
                        .HasColumnType("int");

                    b.Property<string>("EPosta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Isim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyisim")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OgretimUyesiID");

                    b.ToTable("OgretimUyesis");
                });

            modelBuilder.Entity("EntityLayer.ProgramlamaDilleri", b =>
                {
                    b.Property<int>("ProgramlamaDilleriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Final")
                        .HasColumnType("int");

                    b.Property<int>("OgretimUyesiID")
                        .HasColumnType("int");

                    b.Property<int>("Vize1")
                        .HasColumnType("int");

                    b.Property<int>("Vize2")
                        .HasColumnType("int");

                    b.HasKey("ProgramlamaDilleriID");

                    b.HasIndex("OgretimUyesiID");

                    b.ToTable("ProgramlamaDilleris");
                });

            modelBuilder.Entity("EntityLayer.SayisalAnaliz", b =>
                {
                    b.Property<int>("SayısalAnalizID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Final")
                        .HasColumnType("int");

                    b.Property<int>("OgretimUyesiID")
                        .HasColumnType("int");

                    b.Property<int>("Vize1")
                        .HasColumnType("int");

                    b.Property<int>("Vize2")
                        .HasColumnType("int");

                    b.HasKey("SayısalAnalizID");

                    b.HasIndex("OgretimUyesiID");

                    b.ToTable("SayisalAnalizs");
                });

            modelBuilder.Entity("EntityLayer.VeriTabaniYsSis", b =>
                {
                    b.Property<int>("VeriTabanıYsSisID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Final")
                        .HasColumnType("int");

                    b.Property<int>("OgretimUyesiID")
                        .HasColumnType("int");

                    b.Property<int>("Proje")
                        .HasColumnType("int");

                    b.Property<int>("Vize1")
                        .HasColumnType("int");

                    b.Property<int>("Vize2")
                        .HasColumnType("int");

                    b.HasKey("VeriTabanıYsSisID");

                    b.HasIndex("OgretimUyesiID");

                    b.ToTable("VeriTabaniYsSiss");
                });

            modelBuilder.Entity("EntityLayer.VeriYapilari", b =>
                {
                    b.Property<int>("VeriY_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Final")
                        .HasColumnType("int");

                    b.Property<int>("OgretimUyesiID")
                        .HasColumnType("int");

                    b.Property<int>("Proje1")
                        .HasColumnType("int");

                    b.Property<int>("Proje2")
                        .HasColumnType("int");

                    b.Property<int>("Vize1")
                        .HasColumnType("int");

                    b.HasKey("VeriY_Id");

                    b.HasIndex("OgretimUyesiID");

                    b.ToTable("VeriYapilaris");
                });

            modelBuilder.Entity("EntityLayer.MeslekiInglizce", b =>
                {
                    b.HasOne("EntityLayer.OgretimUyesi", "OgretimUyesi")
                        .WithMany("MeslekiInglizces")
                        .HasForeignKey("OgretimUyesiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OgretimUyesi");
                });

            modelBuilder.Entity("EntityLayer.ProgramlamaDilleri", b =>
                {
                    b.HasOne("EntityLayer.OgretimUyesi", "OgretimUyesi")
                        .WithMany("ProgramlamaDilleris")
                        .HasForeignKey("OgretimUyesiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OgretimUyesi");
                });

            modelBuilder.Entity("EntityLayer.SayisalAnaliz", b =>
                {
                    b.HasOne("EntityLayer.OgretimUyesi", "OgretimUyesi")
                        .WithMany("SayisalAnalizs")
                        .HasForeignKey("OgretimUyesiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OgretimUyesi");
                });

            modelBuilder.Entity("EntityLayer.VeriTabaniYsSis", b =>
                {
                    b.HasOne("EntityLayer.OgretimUyesi", "OgretimUyesi")
                        .WithMany("VeriTabaniYsSes")
                        .HasForeignKey("OgretimUyesiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OgretimUyesi");
                });

            modelBuilder.Entity("EntityLayer.VeriYapilari", b =>
                {
                    b.HasOne("EntityLayer.OgretimUyesi", "OgretimUyesi")
                        .WithMany("VeriYapilaris")
                        .HasForeignKey("OgretimUyesiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OgretimUyesi");
                });

            modelBuilder.Entity("EntityLayer.OgretimUyesi", b =>
                {
                    b.Navigation("MeslekiInglizces");

                    b.Navigation("ProgramlamaDilleris");

                    b.Navigation("SayisalAnalizs");

                    b.Navigation("VeriTabaniYsSes");

                    b.Navigation("VeriYapilaris");
                });
#pragma warning restore 612, 618
        }
    }
}
