﻿// <auto-generated />
using System;
using FunWithXml_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FunWithXml_API.Migrations
{
    [DbContext(typeof(FunWithXmlDbContext))]
    [Migration("20240414132632_initdb")]
    partial class initdb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FunWithXml_API.Models.BodyMeasurement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<float>("AnkDi")
                        .HasColumnType("real");

                    b.Property<float>("AnkGi")
                        .HasColumnType("real");

                    b.Property<float>("BiaDi")
                        .HasColumnType("real");

                    b.Property<float>("BicGi")
                        .HasColumnType("real");

                    b.Property<float>("BiiDi")
                        .HasColumnType("real");

                    b.Property<float>("BitDi")
                        .HasColumnType("real");

                    b.Property<float>("CalGi")
                        .HasColumnType("real");

                    b.Property<float>("CheDe")
                        .HasColumnType("real");

                    b.Property<float>("CheDi")
                        .HasColumnType("real");

                    b.Property<float>("CheGi")
                        .HasColumnType("real");

                    b.Property<float>("ElbDi")
                        .HasColumnType("real");

                    b.Property<float>("ForGi")
                        .HasColumnType("real");

                    b.Property<float>("Hgt")
                        .HasColumnType("real");

                    b.Property<float>("HipGi")
                        .HasColumnType("real");

                    b.Property<float>("KneDi")
                        .HasColumnType("real");

                    b.Property<float>("KneGi")
                        .HasColumnType("real");

                    b.Property<float>("NavGi")
                        .HasColumnType("real");

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.Property<float>("ShoGi")
                        .HasColumnType("real");

                    b.Property<float>("ThiGi")
                        .HasColumnType("real");

                    b.Property<float>("WaiGi")
                        .HasColumnType("real");

                    b.Property<float>("Wgt")
                        .HasColumnType("real");

                    b.Property<float>("WriDi")
                        .HasColumnType("real");

                    b.Property<float>("WriGi")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("BodyMeasurements");
                });
#pragma warning restore 612, 618
        }
    }
}