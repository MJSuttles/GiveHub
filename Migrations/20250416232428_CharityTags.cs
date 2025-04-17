using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GiveHub.Migrations
{
    /// <inheritdoc />
    public partial class CharityTags : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Charities_CharityId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_CharityId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "CharityId",
                table: "Tags");

            migrationBuilder.CreateTable(
                name: "CharityTag",
                columns: table => new
                {
                    CharityId = table.Column<int>(type: "integer", nullable: false),
                    TagId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharityTag", x => new { x.CharityId, x.TagId });
                    table.ForeignKey(
                        name: "FK_CharityTag_Charities_CharityId",
                        column: x => x.CharityId,
                        principalTable: "Charities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharityTag_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharityTag_TagId",
                table: "CharityTag",
                column: "TagId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharityTag");

            migrationBuilder.AddColumn<int>(
                name: "CharityId",
                table: "Tags",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tags_CharityId",
                table: "Tags",
                column: "CharityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Charities_CharityId",
                table: "Tags",
                column: "CharityId",
                principalTable: "Charities",
                principalColumn: "Id");
        }
    }
}
