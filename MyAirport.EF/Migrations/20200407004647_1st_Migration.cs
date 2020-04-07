using Microsoft.EntityFrameworkCore.Migrations;

namespace MyAirport.EF.Migrations
{
    public partial class _1st_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Des",
                table: "Vols");

            migrationBuilder.DropColumn(
                name: "Imm",
                table: "Vols");

            migrationBuilder.DropColumn(
                name: "Pax",
                table: "Vols");

            migrationBuilder.DropColumn(
                name: "Pkg",
                table: "Vols");

            migrationBuilder.AddColumn<string>(
                name: "Destination",
                table: "Vols",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Immatriculation",
                table: "Vols",
                nullable: true);

            migrationBuilder.AddColumn<short>(
                name: "NbPassagers",
                table: "Vols",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Parking",
                table: "Vols",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Destination",
                table: "Vols");

            migrationBuilder.DropColumn(
                name: "Immatriculation",
                table: "Vols");

            migrationBuilder.DropColumn(
                name: "NbPassagers",
                table: "Vols");

            migrationBuilder.DropColumn(
                name: "Parking",
                table: "Vols");

            migrationBuilder.AddColumn<string>(
                name: "Des",
                table: "Vols",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Imm",
                table: "Vols",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Pax",
                table: "Vols",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Pkg",
                table: "Vols",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
