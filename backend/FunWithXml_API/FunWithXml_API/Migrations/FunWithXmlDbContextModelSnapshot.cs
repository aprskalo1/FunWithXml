﻿// <auto-generated />
using System;
using FunWithXml_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FunWithXml_API.Migrations
{
    [DbContext(typeof(FunWithXmlDbContext))]
    partial class FunWithXmlDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<float>("ank_di")
                        .HasColumnType("real");

                    b.Property<float>("ank_gi")
                        .HasColumnType("real");

                    b.Property<float>("bia_di")
                        .HasColumnType("real");

                    b.Property<float>("bic_gi")
                        .HasColumnType("real");

                    b.Property<float>("bii_di")
                        .HasColumnType("real");

                    b.Property<float>("bit_di")
                        .HasColumnType("real");

                    b.Property<float>("cal_gi")
                        .HasColumnType("real");

                    b.Property<float>("che_de")
                        .HasColumnType("real");

                    b.Property<float>("che_di")
                        .HasColumnType("real");

                    b.Property<float>("che_gi")
                        .HasColumnType("real");

                    b.Property<float>("elb_di")
                        .HasColumnType("real");

                    b.Property<float>("for_gi")
                        .HasColumnType("real");

                    b.Property<float>("hgt")
                        .HasColumnType("real");

                    b.Property<float>("hip_gi")
                        .HasColumnType("real");

                    b.Property<float>("kne_di")
                        .HasColumnType("real");

                    b.Property<float>("kne_gi")
                        .HasColumnType("real");

                    b.Property<float>("nav_gi")
                        .HasColumnType("real");

                    b.Property<int>("sex")
                        .HasColumnType("int");

                    b.Property<float>("sho_gi")
                        .HasColumnType("real");

                    b.Property<float>("thi_gi")
                        .HasColumnType("real");

                    b.Property<float>("wai_gi")
                        .HasColumnType("real");

                    b.Property<float>("wgt")
                        .HasColumnType("real");

                    b.Property<float>("wri_di")
                        .HasColumnType("real");

                    b.Property<float>("wri_gi")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("BodyMeasurements");
                });
#pragma warning restore 612, 618
        }
    }
}
