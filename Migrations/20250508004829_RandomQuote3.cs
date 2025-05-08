using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GiveHub.Migrations
{
    /// <inheritdoc />
    public partial class RandomQuote3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sentences",
                table: "Quotes",
                newName: "Sentence");

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "Id", "Sentence" },
                values: new object[,]
                {
                    { 1, "The best way to find yourself is to lose yourself in the service of others." },
                    { 2, "Success is not the key to happiness. Happiness is the key to success." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "Sentence",
                table: "Quotes",
                newName: "Sentences");
        }
    }
}
