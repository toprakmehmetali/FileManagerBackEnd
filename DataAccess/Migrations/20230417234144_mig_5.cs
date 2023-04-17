using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class mig_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_Extension_ExtensionId",
                table: "Files");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Extension",
                table: "Extension");

            migrationBuilder.RenameTable(
                name: "Extension",
                newName: "Extensions");

            migrationBuilder.RenameIndex(
                name: "IX_Extension_Name",
                table: "Extensions",
                newName: "IX_Extensions_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Extensions",
                table: "Extensions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Extensions_ExtensionId",
                table: "Files",
                column: "ExtensionId",
                principalTable: "Extensions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_Extensions_ExtensionId",
                table: "Files");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Extensions",
                table: "Extensions");

            migrationBuilder.RenameTable(
                name: "Extensions",
                newName: "Extension");

            migrationBuilder.RenameIndex(
                name: "IX_Extensions_Name",
                table: "Extension",
                newName: "IX_Extension_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Extension",
                table: "Extension",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Extension_ExtensionId",
                table: "Files",
                column: "ExtensionId",
                principalTable: "Extension",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
