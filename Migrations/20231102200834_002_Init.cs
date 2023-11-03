using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightApp.Migrations
{
    /// <inheritdoc />
    public partial class _002_Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Origin",
                table: "Flights",
                newName: "FlightStatus");

            migrationBuilder.RenameColumn(
                name: "FlightNumber",
                table: "Flights",
                newName: "FlightDetails_Number");

            migrationBuilder.RenameColumn(
                name: "Destination",
                table: "Flights",
                newName: "FlightDetails_Icao");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Airports",
                newName: "Timezone");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Airports",
                newName: "Phone_number");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Flights",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "Airline_Iata",
                table: "Flights",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Airline_Icao",
                table: "Flights",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Airline_Name",
                table: "Flights",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "Arrival_Actual",
                table: "Flights",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Arrival_Actual_runway",
                table: "Flights",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Arrival_Airport",
                table: "Flights",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<long>(
                name: "Arrival_Delay",
                table: "Flights",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "Arrival_Estimated",
                table: "Flights",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Arrival_Estimated_runway",
                table: "Flights",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Arrival_Gate",
                table: "Flights",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Arrival_Iata",
                table: "Flights",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Arrival_Icao",
                table: "Flights",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "Arrival_Scheduled",
                table: "Flights",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Arrival_Terminal",
                table: "Flights",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Arrival_Timezone",
                table: "Flights",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "Departure_Actual",
                table: "Flights",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Departure_Actual_runway",
                table: "Flights",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Departure_Airport",
                table: "Flights",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<long>(
                name: "Departure_Delay",
                table: "Flights",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "Departure_Estimated",
                table: "Flights",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Departure_Estimated_runway",
                table: "Flights",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Departure_Gate",
                table: "Flights",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Departure_Iata",
                table: "Flights",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Departure_Icao",
                table: "Flights",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "Departure_Scheduled",
                table: "Flights",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Departure_Terminal",
                table: "Flights",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Departure_Timezone",
                table: "Flights",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "FlightDate",
                table: "Flights",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "FlightDetails_Codeshared",
                table: "Flights",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "FlightDetails_Iata",
                table: "Flights",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Airports",
                type: "char(36)",
                nullable: false,
                collation: "ascii_general_ci",
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "Airport_name",
                table: "Airports",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "City_iata_code",
                table: "Airports",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Country_iso2",
                table: "Airports",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Country_name",
                table: "Airports",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Geoname_id",
                table: "Airports",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Gmt",
                table: "Airports",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Iata_code",
                table: "Airports",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Icao_code",
                table: "Airports",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Latitude",
                table: "Airports",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Longitude",
                table: "Airports",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Airline_Iata",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Airline_Icao",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Airline_Name",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Arrival_Actual",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Arrival_Actual_runway",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Arrival_Airport",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Arrival_Delay",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Arrival_Estimated",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Arrival_Estimated_runway",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Arrival_Gate",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Arrival_Iata",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Arrival_Icao",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Arrival_Scheduled",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Arrival_Terminal",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Arrival_Timezone",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Departure_Actual",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Departure_Actual_runway",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Departure_Airport",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Departure_Delay",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Departure_Estimated",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Departure_Estimated_runway",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Departure_Gate",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Departure_Iata",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Departure_Icao",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Departure_Scheduled",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Departure_Terminal",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Departure_Timezone",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "FlightDate",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "FlightDetails_Codeshared",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "FlightDetails_Iata",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Airport_name",
                table: "Airports");

            migrationBuilder.DropColumn(
                name: "City_iata_code",
                table: "Airports");

            migrationBuilder.DropColumn(
                name: "Country_iso2",
                table: "Airports");

            migrationBuilder.DropColumn(
                name: "Country_name",
                table: "Airports");

            migrationBuilder.DropColumn(
                name: "Geoname_id",
                table: "Airports");

            migrationBuilder.DropColumn(
                name: "Gmt",
                table: "Airports");

            migrationBuilder.DropColumn(
                name: "Iata_code",
                table: "Airports");

            migrationBuilder.DropColumn(
                name: "Icao_code",
                table: "Airports");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Airports");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Airports");

            migrationBuilder.RenameColumn(
                name: "FlightStatus",
                table: "Flights",
                newName: "Origin");

            migrationBuilder.RenameColumn(
                name: "FlightDetails_Number",
                table: "Flights",
                newName: "FlightNumber");

            migrationBuilder.RenameColumn(
                name: "FlightDetails_Icao",
                table: "Flights",
                newName: "Destination");

            migrationBuilder.RenameColumn(
                name: "Timezone",
                table: "Airports",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Phone_number",
                table: "Airports",
                newName: "Code");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Flights",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Airports",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");
        }
    }
}
