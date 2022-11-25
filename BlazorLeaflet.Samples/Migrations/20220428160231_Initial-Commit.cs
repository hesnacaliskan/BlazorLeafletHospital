using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorLeaflet.Samples.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    Latitude = table.Column<double>(type: "REAL", nullable: false),
                    Longitude = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "Latitude", "Longitude", "Name", "Price", "Quantity" },
                values: new object[] { 1001, "This is a best gaming laptop", 0.0, 0.0, "Laptop", 20.02, 10 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "Latitude", "Longitude", "Name", "Price", "Quantity" },
                values: new object[] { 1002, "This is a Office Application", 0.0, 0.0, "Microsoft Office", 20.989999999999998, 50 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "Latitude", "Longitude", "Name", "Price", "Quantity" },
                values: new object[] { 1003, "The mouse that works on all surface", 0.0, 0.0, "Lazer Mouse", 12.02, 20 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "Latitude", "Longitude", "Name", "Price", "Quantity" },
                values: new object[] { 1004, "To store 256GB of data", 0.0, 0.0, "USB Storage", 5.0, 20 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
