using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightApp.Migrations
{
    /// <inheritdoc />
    public partial class _005_AddLiveAndAircraftToFlight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Aircraft_Iata",
                table: "Flights",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Aircraft_Icao",
                table: "Flights",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Aircraft_Icao24",
                table: "Flights",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Aircraft_Registration",
                table: "Flights",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<float>(
                name: "Live_Altitude",
                table: "Flights",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Live_Direction",
                table: "Flights",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Live_Is_ground",
                table: "Flights",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Live_Latitude",
                table: "Flights",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Live_Longitude",
                table: "Flights",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Live_Speed_horizontal",
                table: "Flights",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Live_Speed_vertical",
                table: "Flights",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Live_Updated",
                table: "Flights",
                type: "datetime(6)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aircraft_Iata",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Aircraft_Icao",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Aircraft_Icao24",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Aircraft_Registration",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Live_Altitude",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Live_Direction",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Live_Is_ground",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Live_Latitude",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Live_Longitude",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Live_Speed_horizontal",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Live_Speed_vertical",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Live_Updated",
                table: "Flights");
        }
    }
}
