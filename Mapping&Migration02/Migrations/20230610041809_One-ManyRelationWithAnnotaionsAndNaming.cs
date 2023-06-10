using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mapping_Migration02.Migrations
{
    /// <inheritdoc />
    public partial class OneManyRelationWithAnnotaionsAndNaming : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeptID",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DeptID",
                table: "Employees",
                column: "DeptID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DeptID",
                table: "Employees",
                column: "DeptID",
                principalTable: "Departments",
                principalColumn: "DeptID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DeptID",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DeptID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DeptID",
                table: "Employees");
        }
    }
}
