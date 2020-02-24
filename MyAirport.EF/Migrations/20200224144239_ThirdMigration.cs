using Microsoft.EntityFrameworkCore.Migrations;

namespace MyAirport.EF.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bagage_Vol_VolId",
                table: "Bagage");

            migrationBuilder.AlterColumn<int>(
                name: "VolId",
                table: "Bagage",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Bagage_Vol_VolId",
                table: "Bagage",
                column: "VolId",
                principalTable: "Vol",
                principalColumn: "VolId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bagage_Vol_VolId",
                table: "Bagage");

            migrationBuilder.AlterColumn<int>(
                name: "VolId",
                table: "Bagage",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bagage_Vol_VolId",
                table: "Bagage",
                column: "VolId",
                principalTable: "Vol",
                principalColumn: "VolId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
