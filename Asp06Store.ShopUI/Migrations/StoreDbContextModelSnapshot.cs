﻿// <auto-generated />
using Asp06Store.ShopUI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Asp06Store.ShopUI.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    partial class StoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Asp06Store.ShopUI.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Mobile",
                            Description = "Fast charging (27W, unofficial rating), 50% in 30 min (advertised)USB Power Delivery 2.0MagSafe wireless charging 15WQi magnetic fast wireless charging 7.5W",
                            Name = "Apple 13 Promax",
                            Price = 49000000
                        },
                        new
                        {
                            Id = 2,
                            Category = "Mobile",
                            Description = "Armour aluminum frame with tougher drop and scratch resistance (advertised) Glass front (Gorilla Glass Victus+), glass back (Gorilla Glass Victus+),Samsung DeX, Samsung Wireless DeX (desktop experience support) aluminum   ",
                            Name = "Samsung Galaxy S22 Ultra 5G",
                            Price = 30000000
                        },
                        new
                        {
                            Id = 3,
                            Category = "Mobile",
                            Description = "Wi-Fi 802, dual-band, Wi-Fi Direct, hotspot, Super AMOLED, 120Hz, HDR10, 700 nits (HBM), 1200 nits (peak)",
                            Name = "Xiaomi Redmi Note 11 Pro",
                            Price = 22000000
                        },
                        new
                        {
                            Id = 4,
                            Category = "Mobile",
                            Description = "BlackBerry OS 10.3, upgradable to 10.3.1 Qualcomm MSM8960T Snapdragon S4 Pro",
                            Name = "BlackBerry Porsche Design P'9983",
                            Price = 17000000
                        },
                        new
                        {
                            Id = 5,
                            Category = "LapTop",
                            Description = "Meet the totally mobile Pro. Always with you, instantly ready, and designed to light up the best of Windows 11 Keep up anywhere, at any angle, with a detachable Keyboard* with built-in Slim Pen storage and charging^—plus ",
                            Name = "Surface Pro X",
                            Price = 75000000
                        },
                        new
                        {
                            Id = 6,
                            Category = "LapTop",
                            Description = "Unlock more possibilities than ever with the Pro designed for a Pro like you. The first Surface Pro built on the Intel® Evo™ platform on select configurations†† and designed to light up the best of Windows 11, Surface Pro 8 combines the power ",
                            Name = "Surface Pro 8",
                            Price = 65000000
                        },
                        new
                        {
                            Id = 7,
                            Category = "LapTop",
                            Description = "Our classic Surface Pro 2-in-1 design meets high-speed performance to give you premium laptop versatility, a powerful tablet, or portable digital canvas de",
                            Name = "Surface Pro 7",
                            Price = 42000000
                        },
                        new
                        {
                            Id = 8,
                            Category = "LapTop",
                            Description = "Microsoft Store offers 60day returns on Surface products plus free expert help, digital workshops, and remote learning opportunities. Our online associates will provide free personal assistance to help you get the right Surface for your needs.",
                            Name = "Surface Go 3",
                            Price = 28000000
                        },
                        new
                        {
                            Id = 9,
                            Category = "LapTop",
                            Description = "Zenbook is premium, thin and light, and is the best laptop with top performance and the latest technology to unleash your creative power. ",
                            Name = "Zenbook ",
                            Price = 37000000
                        },
                        new
                        {
                            Id = 10,
                            Category = "LapTop",
                            Description = "The bold and youthful Vivobook series represents who you are. With topnotch performance, gorgeous displays, and efficient cooling, get the job done with ease. ",
                            Name = "Vivobook",
                            Price = 41000000
                        });
                });
#pragma warning restore 612, 618
        }
    }
}