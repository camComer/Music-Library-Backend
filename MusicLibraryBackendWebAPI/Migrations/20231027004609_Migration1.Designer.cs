﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicLibraryBackendWebAPI.Data;

#nullable disable

namespace MusicLibraryBackendWebAPI.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20231027004609_Migration1")]
    partial class Migration1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MusicLibraryBackendWebAPI.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Album")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Songs");
                });
#pragma warning restore 612, 618
        }
    }
}
