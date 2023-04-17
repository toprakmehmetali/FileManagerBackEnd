using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class mig_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Extension",
                table: "Files");

            migrationBuilder.AddColumn<int>(
                name: "ExtensionId",
                table: "Files",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Extension",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extension", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Files_ExtensionId",
                table: "Files",
                column: "ExtensionId");

            migrationBuilder.CreateIndex(
                name: "IX_Extension_Name",
                table: "Extension",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Extension_ExtensionId",
                table: "Files",
                column: "ExtensionId",
                principalTable: "Extension",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_Extension_ExtensionId",
                table: "Files");

            migrationBuilder.DropTable(
                name: "Extension");

            migrationBuilder.DropIndex(
                name: "IX_Files_ExtensionId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "ExtensionId",
                table: "Files");

            migrationBuilder.AddColumn<string>(
                name: "Extension",
                table: "Files",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
