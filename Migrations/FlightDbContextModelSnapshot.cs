﻿// <auto-generated />
using System;
using FlightApp.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FlightApp.Migrations
{
    [DbContext(typeof(FlightDbContext))]
    partial class FlightDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FlightApp.Domain.Entities.Airport", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Airport_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("City_iata_code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Country_iso2")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Country_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Geoname_id")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Gmt")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Iata_code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Icao_code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Latitude")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Longitude")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone_number")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Timezone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Airports");
                });

            modelBuilder.Entity("FlightApp.Domain.Entities.Flight", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("FlightDate")
                        .HasColumnType("longtext");

                    b.Property<string>("FlightStatus")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("FlightApp.Domain.Entities.Flight", b =>
                {
                    b.OwnsOne("FlightApp.Domain.Entities.Aircraft", "Aircraft", b1 =>
                        {
                            b1.Property<Guid>("FlightId")
                                .HasColumnType("char(36)");

                            b1.Property<string>("Iata")
                                .IsRequired()
                                .HasColumnType("longtext");

                            b1.Property<string>("Icao")
                                .IsRequired()
                                .HasColumnType("longtext");

                            b1.Property<string>("Icao24")
                                .IsRequired()
                                .HasColumnType("longtext");

                            b1.Property<string>("Registration")
                                .IsRequired()
                                .HasColumnType("longtext");

                            b1.HasKey("FlightId");

                            b1.ToTable("Flights");

                            b1.WithOwner()
                                .HasForeignKey("FlightId");
                        });

                    b.OwnsOne("FlightApp.Domain.Entities.Airline", "Airline", b1 =>
                        {
                            b1.Property<Guid>("FlightId")
                                .HasColumnType("char(36)");

                            b1.Property<string>("Iata")
                                .HasColumnType("longtext");

                            b1.Property<string>("Icao")
                                .HasColumnType("longtext");

                            b1.Property<string>("Name")
                                .HasColumnType("longtext");

                            b1.HasKey("FlightId");

                            b1.ToTable("Flights");

                            b1.WithOwner()
                                .HasForeignKey("FlightId");
                        });

                    b.OwnsOne("FlightApp.Domain.Entities.Info", "Arrival", b1 =>
                        {
                            b1.Property<Guid>("FlightId")
                                .HasColumnType("char(36)");

                            b1.Property<DateTime?>("Actual")
                                .HasColumnType("datetime(6)");

                            b1.Property<DateTime?>("Actual_runway")
                                .HasColumnType("datetime(6)");

                            b1.Property<string>("Airport")
                                .HasColumnType("longtext");

                            b1.Property<long?>("Delay")
                                .HasColumnType("bigint");

                            b1.Property<DateTime?>("Estimated")
                                .HasColumnType("datetime(6)");

                            b1.Property<DateTime?>("Estimated_runway")
                                .HasColumnType("datetime(6)");

                            b1.Property<string>("Gate")
                                .HasColumnType("longtext");

                            b1.Property<string>("Iata")
                                .HasColumnType("longtext");

                            b1.Property<string>("Icao")
                                .HasColumnType("longtext");

                            b1.Property<DateTime?>("Scheduled")
                                .HasColumnType("datetime(6)");

                            b1.Property<string>("Terminal")
                                .HasColumnType("longtext");

                            b1.Property<string>("Timezone")
                                .HasColumnType("longtext");

                            b1.HasKey("FlightId");

                            b1.ToTable("Flights");

                            b1.WithOwner()
                                .HasForeignKey("FlightId");
                        });

                    b.OwnsOne("FlightApp.Domain.Entities.Info", "Departure", b1 =>
                        {
                            b1.Property<Guid>("FlightId")
                                .HasColumnType("char(36)");

                            b1.Property<DateTime?>("Actual")
                                .HasColumnType("datetime(6)");

                            b1.Property<DateTime?>("Actual_runway")
                                .HasColumnType("datetime(6)");

                            b1.Property<string>("Airport")
                                .HasColumnType("longtext");

                            b1.Property<long?>("Delay")
                                .HasColumnType("bigint");

                            b1.Property<DateTime?>("Estimated")
                                .HasColumnType("datetime(6)");

                            b1.Property<DateTime?>("Estimated_runway")
                                .HasColumnType("datetime(6)");

                            b1.Property<string>("Gate")
                                .HasColumnType("longtext");

                            b1.Property<string>("Iata")
                                .HasColumnType("longtext");

                            b1.Property<string>("Icao")
                                .HasColumnType("longtext");

                            b1.Property<DateTime?>("Scheduled")
                                .HasColumnType("datetime(6)");

                            b1.Property<string>("Terminal")
                                .HasColumnType("longtext");

                            b1.Property<string>("Timezone")
                                .HasColumnType("longtext");

                            b1.HasKey("FlightId");

                            b1.ToTable("Flights");

                            b1.WithOwner()
                                .HasForeignKey("FlightId");
                        });

                    b.OwnsOne("FlightApp.Domain.Entities.FlightDetails", "FlightDetails", b1 =>
                        {
                            b1.Property<Guid>("FlightId")
                                .HasColumnType("char(36)");

                            b1.Property<string>("Iata")
                                .HasColumnType("longtext");

                            b1.Property<string>("Icao")
                                .HasColumnType("longtext");

                            b1.Property<string>("Number")
                                .HasColumnType("longtext");

                            b1.HasKey("FlightId");

                            b1.ToTable("Flights");

                            b1.WithOwner()
                                .HasForeignKey("FlightId");

                            b1.OwnsOne("FlightApp.Domain.Entities.Codeshared", "Codeshared", b2 =>
                                {
                                    b2.Property<Guid>("FlightDetailsFlightId")
                                        .HasColumnType("char(36)");

                                    b2.Property<string>("Airline_iata")
                                        .HasColumnType("longtext");

                                    b2.Property<string>("Airline_icao")
                                        .HasColumnType("longtext");

                                    b2.Property<string>("Airline_name")
                                        .HasColumnType("longtext");

                                    b2.Property<string>("Flight_iata")
                                        .HasColumnType("longtext");

                                    b2.Property<string>("Flight_icao")
                                        .HasColumnType("longtext");

                                    b2.Property<string>("Flight_number")
                                        .HasColumnType("longtext");

                                    b2.HasKey("FlightDetailsFlightId");

                                    b2.ToTable("Flights");

                                    b2.WithOwner()
                                        .HasForeignKey("FlightDetailsFlightId");
                                });

                            b1.Navigation("Codeshared");
                        });

                    b.OwnsOne("FlightApp.Domain.Entities.Live", "Live", b1 =>
                        {
                            b1.Property<Guid>("FlightId")
                                .HasColumnType("char(36)");

                            b1.Property<float>("Altitude")
                                .HasColumnType("float");

                            b1.Property<float>("Direction")
                                .HasColumnType("float");

                            b1.Property<bool>("Is_ground")
                                .HasColumnType("tinyint(1)");

                            b1.Property<float>("Latitude")
                                .HasColumnType("float");

                            b1.Property<float>("Longitude")
                                .HasColumnType("float");

                            b1.Property<float>("Speed_horizontal")
                                .HasColumnType("float");

                            b1.Property<float>("Speed_vertical")
                                .HasColumnType("float");

                            b1.Property<DateTime?>("Updated")
                                .HasColumnType("datetime(6)");

                            b1.HasKey("FlightId");

                            b1.ToTable("Flights");

                            b1.WithOwner()
                                .HasForeignKey("FlightId");
                        });

                    b.Navigation("Aircraft");

                    b.Navigation("Airline");

                    b.Navigation("Arrival");

                    b.Navigation("Departure");

                    b.Navigation("FlightDetails")
                        .IsRequired();

                    b.Navigation("Live");
                });
#pragma warning restore 612, 618
        }
    }
}