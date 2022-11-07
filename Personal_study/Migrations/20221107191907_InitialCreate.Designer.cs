﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Personal_study.Data;

namespace Personal_study.Migrations
{
    [DbContext(typeof(Personal_studyContext))]
    [Migration("20221107191907_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Personal_study.Scripture_note.Scripture_entry", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("scripture_date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("scripture_note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("scripture_reference")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("scripture_text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Scripture_entry");
                });
#pragma warning restore 612, 618
        }
    }
}
