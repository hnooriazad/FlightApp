using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightApp.Migrations
{
    /// <inheritdoc />
    public partial class _003_SomeChangesOnFlight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FlightDetails_Codeshared",
                table: "Flights",
                newName: "FlightDetails_Codeshared_Flight_number");

            migrationBuilder.AddColumn<string>(
                name: "FlightDetails_Codeshared_Airline_iata",
                table: "Flights",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "FlightDetails_Codeshared_Airline_icao",
                table: "Flights",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "FlightDetails_Codeshared_Airline_name",
                table: "Flights",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "FlightDetails_Codeshared_Flight_iata",
                table: "Flights",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "FlightDetails_Codeshared_Flight_icao",
                table: "Flights",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FlightDetails_Codeshared_Airline_iata",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "FlightDetails_Codeshared_Airline_icao",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "FlightDetails_Codeshared_Airline_name",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "FlightDetails_Codeshared_Flight_iata",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "FlightDetails_Codeshared_Flight_icao",
                table: "Flights");

            migrationBuilder.RenameColumn(
                name: "FlightDetails_Codeshared_Flight_number",
                table: "Flights",
                newName: "FlightDetails_Codeshared");
        }
    }
}
