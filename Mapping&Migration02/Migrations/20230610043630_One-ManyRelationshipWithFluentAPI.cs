using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mapping_Migration02.Migrations
{
    /// <inheritdoc />
    public partial class OneManyRelationshipWithFluentAPI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ProjId",
                table: "Employees",
                column: "ProjId");

            migrationBuilder.AddForeignKey(
                name: "Employee_ProjectNumber_FK",
                table: "Employees",
                column: "ProjId",
                principalTable: "Project",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "Employee_ProjectNumber_FK",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ProjId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ProjId",
                table: "Employees");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Departments",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
