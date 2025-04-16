using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GiveHub.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Charities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserUid = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Owners = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Street = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    State = table.Column<string>(type: "text", nullable: false),
                    Zip = table.Column<string>(type: "text", nullable: false),
                    ContactName = table.Column<string>(type: "text", nullable: false),
                    ContactEmail = table.Column<string>(type: "text", nullable: false),
                    ContactPhone = table.Column<string>(type: "text", nullable: false),
                    Website = table.Column<string>(type: "text", nullable: false),
                    Donations = table.Column<decimal>(type: "numeric", nullable: false),
                    Stars = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Charities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserUid = table.Column<string>(type: "text", nullable: false),
                    CharityId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Street = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    State = table.Column<string>(type: "text", nullable: false),
                    Zip = table.Column<string>(type: "text", nullable: false),
                    ContactName = table.Column<string>(type: "text", nullable: false),
                    ContactEmail = table.Column<string>(type: "text", nullable: false),
                    ContactPhone = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Charities_CharityId",
                        column: x => x.CharityId,
                        principalTable: "Charities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CharityId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tags_Charities_CharityId",
                        column: x => x.CharityId,
                        principalTable: "Charities",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Charities",
                columns: new[] { "Id", "City", "ContactEmail", "ContactName", "ContactPhone", "Description", "Donations", "Image", "Name", "Owners", "Stars", "State", "Street", "UserUid", "Website", "Zip" },
                values: new object[,]
                {
                    { 1, "Springfield", "alice@hopeforall.org", "Alice Johnson", "555-123-4567", "Helping underserved communities with education and shelter.", 3500m, "https://example.com/images/hope.jpg", "Hope for All", "Alice Johnson", 4, "IL", "123 Unity Lane", "uid-hope1", "https://hopeforall.org", "62704" },
                    { 2, "Boulder", "brian@greenearth.org", "Brian Meadows", "555-765-4321", "Promoting environmental sustainability and awareness.", 8900m, "https://example.com/images/green.jpg", "Green Earth Fund", "Brian Meadows", 5, "CO", "45 Nature Ave", "uid-earth2", "https://greenearth.org", "80301" },
                    { 3, "Portland", "catherine@foodforward.org", "Catherine Lee", "555-789-0000", "Connecting food donors with hunger relief programs.", 12000m, "https://example.com/images/foodforward.jpg", "Food Forward", "Catherine Lee", 5, "OR", "88 Kindness Blvd", "uid-food3", "https://foodforward.org", "97201" },
                    { 4, "Austin", "david@booksforkids.org", "David Chen", "555-321-7890", "Providing books and literacy programs for children.", 5000m, "https://example.com/images/books.jpg", "Books for Kids", "David Chen", 4, "TX", "212 Literacy Ln", "uid-books4", "https://booksforkids.org", "73301" },
                    { 5, "Phoenix", "erika@safehaven.org", "Erika Martinez", "555-456-9999", "Supporting homeless individuals with food and housing.", 7400m, "https://example.com/images/shelter.jpg", "Safe Haven Shelter", "Erika Martinez", 5, "AZ", "678 Hope St", "uid-safe5", "https://safehaven.org", "85001" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "CharityId", "City", "ContactEmail", "ContactName", "ContactPhone", "Date", "Description", "Image", "Name", "State", "Street", "UserUid", "Zip" },
                values: new object[,]
                {
                    { 1, 1, "Springfield", "alice@hopeforall.org", "Alice Johnson", "555-123-4567", new DateTime(2025, 8, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), "Providing school supplies to children in need.", "https://example.com/images/schooldrive.jpg", "Back-to-School Drive", "IL", "123 Unity Lane", "uid-hope1", "62704" },
                    { 2, 2, "Boulder", "brian@greenearth.org", "Brian Meadows", "555-765-4321", new DateTime(2025, 4, 22, 9, 0, 0, 0, DateTimeKind.Unspecified), "Community tree planting initiative.", "https://example.com/images/trees.jpg", "Tree Planting Day", "CO", "45 Nature Ave", "uid-earth2", "80301" },
                    { 3, 3, "Portland", "catherine@foodforward.org", "Catherine Lee", "555-789-0000", new DateTime(2025, 5, 15, 13, 30, 0, 0, DateTimeKind.Unspecified), "Volunteers needed for distributing donated food.", "https://example.com/images/food.jpg", "Food Distribution Weekend", "OR", "88 Kindness Blvd", "uid-food3", "97201" },
                    { 4, 4, "Austin", "david@booksforkids.org", "David Chen", "555-321-7890", new DateTime(2025, 6, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), "Raising funds by reading books for donations.", "https://example.com/images/readathon.jpg", "Read-a-Thon Fundraiser", "TX", "212 Literacy Ln", "uid-books4", "73301" },
                    { 5, 5, "Phoenix", "erika@safehaven.org", "Erika Martinez", "555-456-9999", new DateTime(2025, 7, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), "Connecting homeless individuals with resources.", "https://example.com/images/outreach.jpg", "Homeless Outreach Day", "AZ", "678 Hope St", "uid-safe5", "85001" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_CharityId",
                table: "Events",
                column: "CharityId");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_CharityId",
                table: "Tags",
                column: "CharityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Charities");
        }
    }
}
