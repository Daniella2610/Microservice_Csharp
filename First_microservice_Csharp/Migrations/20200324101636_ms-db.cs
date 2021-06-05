using Microsoft.EntityFrameworkCore.Migrations;

namespace First_microservice_Csharp.Migrations
{
    public partial class msdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catalogs",
                columns: table => new
                {
                    CatagoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalogs", x => x.CatagoryId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    CatagoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Catalogs",
                columns: new[] { "CatagoryId", "Description", "Name" },
                values: new object[] { 1, "Electronic Items", "Electronics" });

            migrationBuilder.InsertData(
                table: "Catalogs",
                columns: new[] { "CatagoryId", "Description", "Name" },
                values: new object[] { 2, "Dresses", "Clothes" });

            migrationBuilder.InsertData(
                table: "Catalogs",
                columns: new[] { "CatagoryId", "Description", "Name" },
                values: new object[] { 3, "Grocery Items", "Grocery" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catalogs");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
