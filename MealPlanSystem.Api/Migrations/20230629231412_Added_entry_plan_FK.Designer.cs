﻿// <auto-generated />
using System;
using MealPlanSystem;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MealPlanSystem.Api.Migrations
{
    [DbContext(typeof(MealPlanDbContext))]
    [Migration("20230629231412_Added_entry_plan_FK")]
    partial class Added_entry_plan_FK
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MealPlanSystem.Features.MealPlan.Plan", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("NVARCHAR(2000)");

                    b.Property<DateTimeOffset?>("EndDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(200)");

                    b.Property<DateTimeOffset?>("StartDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("Plan");
                });

            modelBuilder.Entity("MealPlanSystem.Features.MealPlanEntry.PlanEntry", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("Amount")
                        .HasColumnType("DECIMAL(38,5)");

                    b.Property<decimal?>("Cost")
                        .HasColumnType("DECIMAL(38,5)");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("EndDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(200)");

                    b.Property<string>("Notes")
                        .HasColumnType("NVARCHAR(2000)");

                    b.Property<Guid>("PlanEntryTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset?>("StartDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("UnitTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PlanEntryTypeId");

                    b.HasIndex("PlanId");

                    b.ToTable("PlanEntry");
                });

            modelBuilder.Entity("MealPlanSystem.Features.MealPlanEntryType.PlanEntryType", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DisplayName")
                        .HasColumnType("NVARCHAR(2000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(200)");

                    b.HasKey("Id");

                    b.ToTable("PlanEntryType");
                });

            modelBuilder.Entity("MealPlanSystem.Features.MealPlanEntry.PlanEntry", b =>
                {
                    b.HasOne("MealPlanSystem.Features.MealPlanEntryType.PlanEntryType", "PlanEntryType")
                        .WithMany()
                        .HasForeignKey("PlanEntryTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MealPlanSystem.Features.MealPlan.Plan", "Plan")
                        .WithMany()
                        .HasForeignKey("PlanId");

                    b.Navigation("Plan");

                    b.Navigation("PlanEntryType");
                });
#pragma warning restore 612, 618
        }
    }
}