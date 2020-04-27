using Microsoft.EntityFrameworkCore.Migrations;

namespace MyAirport.EF.Migrations
{
    public partial class _3th_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bagages_Vol_VolId",
                table: "Bagages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vol",
                table: "Vol");

            migrationBuilder.RenameTable(
                name: "Vol",
                newName: "Vols");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vols",
                table: "Vols",
                column: "VolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bagages_Vols_VolId",
                table: "Bagages",
                column: "VolId",
                principalTable: "Vols",
                principalColumn: "VolId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bagages_Vols_VolId",
                table: "Bagages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vols",
                table: "Vols");

            migrationBuilder.RenameTable(
                name: "Vols",
                newName: "Vol");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vol",
                table: "Vol",
                column: "VolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bagages_Vol_VolId",
                table: "Bagages",
                column: "VolId",
                principalTable: "Vol",
                principalColumn: "VolId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
