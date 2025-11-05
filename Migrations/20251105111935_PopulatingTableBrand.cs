using Microsoft.EntityFrameworkCore.Migrations;
using MVeiculos.Modelos;

#nullable disable

namespace MVeiculos.Migrations
{
    /// <inheritdoc />
    public partial class PopulatinTableBrand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name", "Logo" },
                values: new object[,]
                {
                    {1, "Toyota", "https://upload.wikimedia.org/wikipedia/commons/9/9d/Toyota_carlogo.svg" },
                    { 2, "Honda", "https://upload.wikimedia.org/wikipedia/commons/7/7b/Honda-logo.svg" },
                    { 3, "Ford", "https://upload.wikimedia.org/wikipedia/commons/3/3e/Ford_logo_flat.svg" }
        } );
    }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Brands");
        }
    }
}
