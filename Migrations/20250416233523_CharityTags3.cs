using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GiveHub.Migrations
{
    /// <inheritdoc />
    public partial class CharityTags3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharityTag_Charities_CharityId",
                table: "CharityTag");

            migrationBuilder.DropForeignKey(
                name: "FK_CharityTag_Tags_TagId",
                table: "CharityTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharityTag",
                table: "CharityTag");

            migrationBuilder.RenameTable(
                name: "CharityTag",
                newName: "CharityTags");

            migrationBuilder.RenameIndex(
                name: "IX_CharityTag_TagId",
                table: "CharityTags",
                newName: "IX_CharityTags_TagId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharityTags",
                table: "CharityTags",
                columns: new[] { "CharityId", "TagId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CharityTags_Charities_CharityId",
                table: "CharityTags",
                column: "CharityId",
                principalTable: "Charities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharityTags_Tags_TagId",
                table: "CharityTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharityTags_Charities_CharityId",
                table: "CharityTags");

            migrationBuilder.DropForeignKey(
                name: "FK_CharityTags_Tags_TagId",
                table: "CharityTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharityTags",
                table: "CharityTags");

            migrationBuilder.RenameTable(
                name: "CharityTags",
                newName: "CharityTag");

            migrationBuilder.RenameIndex(
                name: "IX_CharityTags_TagId",
                table: "CharityTag",
                newName: "IX_CharityTag_TagId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharityTag",
                table: "CharityTag",
                columns: new[] { "CharityId", "TagId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CharityTag_Charities_CharityId",
                table: "CharityTag",
                column: "CharityId",
                principalTable: "Charities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharityTag_Tags_TagId",
                table: "CharityTag",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
