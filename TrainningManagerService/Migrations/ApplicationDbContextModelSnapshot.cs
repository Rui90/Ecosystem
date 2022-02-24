﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrainningManagerService.Context;

#nullable disable

namespace TrainningManagerService.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PlanVideo", b =>
                {
                    b.Property<Guid>("PlanId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("VideosId")
                        .HasColumnType("char(36)");

                    b.HasKey("PlanId", "VideosId");

                    b.HasIndex("VideosId");

                    b.ToTable("PlanVideo");
                });

            modelBuilder.Entity("TrainningManagerService.Entities.Database.Plan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("DurationInSeconds")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Plans");
                });

            modelBuilder.Entity("TrainningManagerService.Entities.Database.Video", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Area")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("DurationInSeconds")
                        .HasColumnType("bigint");

                    b.Property<bool>("EquipmentRequired")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("varchar(512)");

                    b.Property<int>("VideoGoal")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("PlanVideo", b =>
                {
                    b.HasOne("TrainningManagerService.Entities.Database.Plan", null)
                        .WithMany()
                        .HasForeignKey("PlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrainningManagerService.Entities.Database.Video", null)
                        .WithMany()
                        .HasForeignKey("VideosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
