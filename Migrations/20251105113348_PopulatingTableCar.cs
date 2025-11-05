using Microsoft.EntityFrameworkCore.Migrations;
using MVeiculos.Modelos;

#nullable disable

namespace MVeiculos.Migrations
{
    /// <inheritdoc />
    public partial class PopulatingTableCar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Name", "CarYear", "Color", "Price", "BrandId" },
                values: new object[,]
                {
                    {"Corolla", 2024, "Prata", 140000, 1 },
                    {"Civic", 2023, "Preto", 120000, 2}
                }

                );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Cars");
        }
    }
}
