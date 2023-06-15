using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inheritance.Migrations
{
    /// <inheritdoc />
    public partial class OwnedEntityDifferentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Store",
                table: "Store");

            migrationBuilder.DropColumn(
                name: "FullAddress_CountryCode",
                table: "Store");

            migrationBuilder.DropColumn(
                name: "FullAddress_FirstAddress",
                table: "Store");

            migrationBuilder.DropColumn(
                name: "FullAddress_SecondAddress",
                table: "Store");

            migrationBuilder.DropColumn(
                name: "FullAddress_ThirdAddress",
                table: "Store");

            migrationBuilder.DropColumn(
                name: "FullAddress_ZipCode",
                table: "Store");

            migrationBuilder.RenameTable(
                name: "Store",
                newName: "Stores");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stores",
                table: "Stores",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "FullAddress",
                columns: table => new
                {
                    StoreID = table.Column<int>(type: "int", nullable: false),
                    FirstAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SecondAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ThirdAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CountryCode = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FullAddress", x => x.StoreID);
                    table.ForeignKey(
                        name: "FK_FullAddress_Stores_StoreID",
                        column: x => x.StoreID,
                        principalTable: "Stores",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FullAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stores",
                table: "Stores");

            migrationBuilder.RenameTable(
                name: "Stores",
                newName: "Store");

            migrationBuilder.AddColumn<string>(
                name: "FullAddress_CountryCode",
                table: "Store",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullAddress_FirstAddress",
                table: "Store",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullAddress_SecondAddress",
                table: "Store",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullAddress_ThirdAddress",
                table: "Store",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullAddress_ZipCode",
                table: "Store",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Store",
                table: "Store",
                column: "ID");
        }
    }
}
