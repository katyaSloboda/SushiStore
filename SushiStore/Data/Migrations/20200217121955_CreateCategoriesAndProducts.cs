using Microsoft.EntityFrameworkCore.Migrations;

namespace SushiStore.Data.Migrations
{
    public partial class CreateCategoriesAndProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<int>(nullable: false),
                    NameKey = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    NameKey = table.Column<string>(nullable: true),
                    CompositionKey = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    Calories = table.Column<int>(nullable: false),
                    Proteins = table.Column<int>(nullable: false),
                    Fats = table.Column<int>(nullable: false),
                    Carbohydrates = table.Column<int>(nullable: false),
                    IsSpicy = table.Column<bool>(nullable: false),
                    IsVegetarian = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
