﻿// <auto-generated />
using System;
using CalendarEventWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CalendarEventWebApp.Migrations
{
    [DbContext(typeof(EventContext))]
    [Migration("20210422212550_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CalendarEventWebApp.Models.EventDetails", b =>
                {
                    b.Property<int>("EventDetailsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EventLocationLocationID")
                        .HasColumnType("int");

                    b.Property<string>("EventTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("EventDetailsID");

                    b.HasIndex("EventLocationLocationID");

                    b.ToTable("EventDetails");
                });

            modelBuilder.Entity("CalendarEventWebApp.Models.EventLocation", b =>
                {
                    b.Property<int>("LocationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("LocationLatitude")
                        .HasColumnType("float");

                    b.Property<double>("LocationLongitude")
                        .HasColumnType("float");

                    b.Property<string>("LocationName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationID");

                    b.ToTable("EventLocation");
                });

            modelBuilder.Entity("CalendarEventWebApp.Models.EventDetails", b =>
                {
                    b.HasOne("CalendarEventWebApp.Models.EventLocation", null)
                        .WithMany("EventDetails")
                        .HasForeignKey("EventLocationLocationID");
                });

            modelBuilder.Entity("CalendarEventWebApp.Models.EventLocation", b =>
                {
                    b.Navigation("EventDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
