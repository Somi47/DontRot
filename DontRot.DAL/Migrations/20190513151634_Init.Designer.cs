﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using DontRot.DAL;

namespace DontRot.DAL.Migrations
{
    [DbContext(typeof(DontRotContext))]
    [Migration("20190513151634_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DontRot.DAL.Entities.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<DateTime>("ExpiryDateTime");

                    b.Property<string>("Name");

                    b.Property<int>("Quantity");

                    b.Property<int>("SlotId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SlotId");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            ExpiryDateTime = new DateTime(2019, 5, 18, 17, 16, 34, 472, DateTimeKind.Local).AddTicks(2497),
                            Name = "Mizo dobozos tej",
                            Quantity = 1,
                            SlotId = 2
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            ExpiryDateTime = new DateTime(2019, 5, 16, 17, 16, 34, 475, DateTimeKind.Local).AddTicks(2144),
                            Name = "Alföldi zacskós tej",
                            Quantity = 1,
                            SlotId = 2
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            ExpiryDateTime = new DateTime(2019, 5, 24, 17, 16, 34, 475, DateTimeKind.Local).AddTicks(2198),
                            Name = "Pick szeletelt téliszalámi",
                            Quantity = 5,
                            SlotId = 1
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            ExpiryDateTime = new DateTime(2019, 7, 24, 17, 16, 34, 475, DateTimeKind.Local).AddTicks(2237),
                            Name = "CBA páros kolbász",
                            Quantity = 1,
                            SlotId = 1
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 4,
                            ExpiryDateTime = new DateTime(2019, 5, 17, 17, 16, 34, 475, DateTimeKind.Local).AddTicks(2271),
                            Name = "Spanyol banán",
                            Quantity = 3,
                            SlotId = 3
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            ExpiryDateTime = new DateTime(2021, 3, 9, 17, 16, 34, 475, DateTimeKind.Local).AddTicks(2315),
                            Name = "Bab konzerv",
                            Quantity = 2,
                            SlotId = 4
                        });
                });

            modelBuilder.Entity("DontRot.DAL.Entities.Slot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("StorageId");

                    b.HasKey("Id");

                    b.HasIndex("StorageId");

                    b.ToTable("Slots");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Felső polc",
                            StorageId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Alsó polc",
                            StorageId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Bal fiók",
                            StorageId = 2
                        },
                        new
                        {
                            Id = 4,
                            Name = "Jobb fiók",
                            StorageId = 2
                        });
                });

            modelBuilder.Entity("DontRot.DAL.Entities.Storage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Storages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Hűtő"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Konyhaszekrény"
                        });
                });

            modelBuilder.Entity("DontRot.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Tej"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Felvágott"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Konzerv"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Banán"
                        });
                });

            modelBuilder.Entity("DontRot.DAL.Entities.Food", b =>
                {
                    b.HasOne("DontRot.Entities.Category", "Category")
                        .WithMany("Foods")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DontRot.DAL.Entities.Slot", "Slot")
                        .WithMany("Foods")
                        .HasForeignKey("SlotId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DontRot.DAL.Entities.Slot", b =>
                {
                    b.HasOne("DontRot.DAL.Entities.Storage", "Storage")
                        .WithMany("Slots")
                        .HasForeignKey("StorageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
