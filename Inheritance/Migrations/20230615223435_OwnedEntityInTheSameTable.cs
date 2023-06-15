using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inheritance.Migrations
{
    /// <inheritdoc />
    public partial class OwnedEntityInTheSameTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    FullAddress_FirstAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FullAddress_SecondAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FullAddress_ThirdAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FullAddress_ZipCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FullAddress_CountryCode = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Store");
        }
    }
}
