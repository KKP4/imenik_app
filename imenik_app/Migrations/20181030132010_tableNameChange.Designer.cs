﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using imenik_app.imenikDB;

namespace imenik_app.Migrations
{
    [DbContext(typeof(ImenikDbContext))]
    [Migration("20181030132010_tableNameChange")]
    partial class tableNameChange
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("imenik_app.Models.Kontakt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ime");

                    b.Property<string>("Naslov");

                    b.Property<string>("Priimek");

                    b.Property<string>("TelStevilka");

                    b.HasKey("Id");

                    b.ToTable("Kontakti");
                });
#pragma warning restore 612, 618
        }
    }
}
