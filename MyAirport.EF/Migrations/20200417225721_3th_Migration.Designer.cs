﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyAirport.EF;

namespace MyAirport.EF.Migrations
{
    [DbContext(typeof(MyAirportContext))]
    [Migration("20200417225721_3th_Migration")]
    partial class _3th_Migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyAirport.EF.Bagage", b =>
                {
                    b.Property<int>("BagageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Classe")
                        .IsRequired()
                        .HasColumnType("char(12)");

                    b.Property<string>("CodeIata")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("char(12)");

                    b.Property<string>("Escale")
                        .IsRequired()
                        .HasColumnType("char(12)");

                    b.Property<string>("Prioritaire")
                        .IsRequired()
                        .HasColumnType("char(12)");

                    b.Property<string>("SSUR")
                        .IsRequired()
                        .HasColumnType("char(12)");

                    b.Property<string>("Sta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VolId")
                        .HasColumnType("int");

                    b.HasKey("BagageId");

                    b.HasIndex("VolId");

                    b.ToTable("Bagages");
                });

            modelBuilder.Entity("MyAirport.EF.Vol", b =>
                {
                    b.Property<int>("VolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Destination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dhc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Immatriculation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lig")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("NbPassagers")
                        .HasColumnType("smallint");

                    b.Property<string>("Parking")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VolId");

                    b.ToTable("Vols");
                });

            modelBuilder.Entity("MyAirport.EF.Bagage", b =>
                {
                    b.HasOne("MyAirport.EF.Vol", "Vol")
                        .WithMany("Bagages")
                        .HasForeignKey("VolId");
                });
#pragma warning restore 612, 618
        }
    }
}
