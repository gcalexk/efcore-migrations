﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using efcore_bl.Data;

namespace efcore_bl.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210512154844_TableFKProperty")]
    partial class TableFKProperty
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("efcore_bl.Data.KnightTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("MaxSeats")
                        .HasColumnType("int");

                    b.Property<string>("Shape")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("KnightTable");
                });

            modelBuilder.Entity("efcore_bl.Data.TestKnight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Quest")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("TableId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TableId");

                    b.ToTable("TestKnights");
                });

            modelBuilder.Entity("efcore_bl.Data.TestKnight", b =>
                {
                    b.HasOne("efcore_bl.Data.KnightTable", "Table")
                        .WithMany("Knights")
                        .HasForeignKey("TableId");

                    b.Navigation("Table");
                });

            modelBuilder.Entity("efcore_bl.Data.KnightTable", b =>
                {
                    b.Navigation("Knights");
                });
#pragma warning restore 612, 618
        }
    }
}