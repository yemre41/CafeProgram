﻿// <auto-generated />
using CafeProgram.Models.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CafeProgram.Migrations
{
    [DbContext(typeof(DbCafe))]
    [Migration("20220824171718_mig2")]
    partial class mig2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CafeProgram.Models.EntityFramework.DbCafe+Icecek", b =>
                {
                    b.Property<int>("icecekId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("icecekName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("icecekValue")
                        .HasColumnType("real");

                    b.HasKey("icecekId");

                    b.ToTable("icecekler");
                });

            modelBuilder.Entity("CafeProgram.Models.EntityFramework.DbCafe+Tatlı", b =>
                {
                    b.Property<int>("tatlıId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("tatlıName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("tatlıValue")
                        .HasColumnType("real");

                    b.HasKey("tatlıId");

                    b.ToTable("tatlilar");
                });

            modelBuilder.Entity("CafeProgram.Models.EntityFramework.DbCafe+Yiyecek", b =>
                {
                    b.Property<int>("yiyecekId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("yiyecekName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("yiyecekValue")
                        .HasColumnType("real");

                    b.HasKey("yiyecekId");

                    b.ToTable("yiyecekler");
                });
#pragma warning restore 612, 618
        }
    }
}