﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewForReact.Data;

#nullable disable

namespace CriptoProjectTest.Migrations
{
    [DbContext(typeof(DataDbContent))]
    [Migration("20240523182912_second")]
    partial class Second
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CriptoProjectTest.Entityes.Asset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AssetId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateLastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("PriceUsd")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Assets");

                    b.HasData(
                        new
                        {
                            Id = 5,
                            AssetId = "PEPE",
                            DateLastUpdate = new DateTime(2024, 5, 23, 19, 29, 12, 357, DateTimeKind.Local).AddTicks(3510),
                            Name = "PepeCoin"
                        },
                        new
                        {
                            Id = 2,
                            AssetId = "BTC",
                            DateLastUpdate = new DateTime(2024, 5, 23, 19, 29, 12, 357, DateTimeKind.Local).AddTicks(3579),
                            Name = "Bitcoin"
                        },
                        new
                        {
                            Id = 3,
                            AssetId = "Ethereum",
                            DateLastUpdate = new DateTime(2024, 5, 23, 19, 29, 12, 357, DateTimeKind.Local).AddTicks(3625),
                            Name = "Ethereum"
                        },
                        new
                        {
                            Id = 4,
                            AssetId = "TNT",
                            DateLastUpdate = new DateTime(2024, 5, 23, 19, 29, 12, 357, DateTimeKind.Local).AddTicks(3628),
                            Name = "Tierion"
                        },
                        new
                        {
                            Id = 1,
                            AssetId = "USD",
                            DateLastUpdate = new DateTime(2024, 5, 23, 19, 29, 12, 357, DateTimeKind.Local).AddTicks(3631),
                            Name = "US Dollar"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
