﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OmnIDEApi.Data;

#nullable disable

namespace OmnIDEApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250421115519_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.4");

            modelBuilder.Entity("OmnIDEApi.Models.ProjectConfiguration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProgrammingLanguage")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectPath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProjectPath")
                        .IsUnique();

                    b.ToTable("ProjectConfigurations");
                });
#pragma warning restore 612, 618
        }
    }
}
