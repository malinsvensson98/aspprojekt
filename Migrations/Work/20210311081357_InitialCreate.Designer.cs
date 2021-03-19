﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using aspprojekt.Data;

namespace aspprojekt.Migrations.Work
{
    [DbContext(typeof(WorkContext))]
    [Migration("20210311081357_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("aspprojekt.Models.Works", b =>
                {
                    b.Property<int>("WorkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkLength")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("WorkId");

                    b.ToTable("Works");
                });
#pragma warning restore 612, 618
        }
    }
}
