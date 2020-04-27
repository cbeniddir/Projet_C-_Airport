using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyAirport.EF.Migrations
{
    public partial class _1st_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vol",
                columns: table => new
                {
                    VolId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cie = table.Column<string>(nullable: false),
                    Lig = table.Column<string>(nullable: false),
                    Dhc = table.Column<DateTime>(nullable: false),
                    Parking = table.Column<string>(nullable: true),
                    Immatriculation = table.Column<string>(nullable: true),
                    NbPassagers = table.Column<short>(nullable: true),
                    Destination = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vol", x => x.VolId);
                });

            migrationBuilder.CreateTable(
                name: "Bagages",
                columns: table => new
                {
                    BagageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VolId = table.Column<int>(nullable: true),
                    DateCreation = table.Column<DateTime>(nullable: false),
                    CodeIata = table.Column<string>(nullable: false),
                    Classe = table.Column<string>(type: "char(12)", nullable: false),
                    Prioritaire = table.Column<string>(type: "char(12)", nullable: false),
                    Sta = table.Column<string>(nullable: false),
                    SSUR = table.Column<string>(type: "char(12)", nullable: false),
                    Destination = table.Column<string>(type: "char(12)", nullable: false),
                    Escale = table.Column<string>(type: "char(12)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bagages", x => x.BagageId);
                    table.ForeignKey(
                        name: "FK_Bagages_Vol_VolId",
                        column: x => x.VolId,
                        principalTable: "Vol",
                        principalColumn: "VolId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bagages_VolId",
                table: "Bagages",
                column: "VolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bagages");

            migrationBuilder.DropTable(
                name: "Vol");
        }
    }
}
