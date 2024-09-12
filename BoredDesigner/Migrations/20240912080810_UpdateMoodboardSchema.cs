using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoredDesigner.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMoodboardSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Moodboards_Users_UserId",
                table: "Moodboards");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Moodboards",
                newName: "TextureImageUrl");

            migrationBuilder.RenameColumn(
                name: "ThumbnailUrl",
                table: "Moodboards",
                newName: "SecondaryFontUrl");

            migrationBuilder.RenameColumn(
                name: "BackgroundColorHex",
                table: "Moodboards",
                newName: "PrimaryFontUrl");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Moodboards",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "Color1",
                table: "Moodboards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Color2",
                table: "Moodboards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Color3",
                table: "Moodboards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Color4",
                table: "Moodboards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Color5",
                table: "Moodboards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Moodboards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Moodboards_Users_UserId",
                table: "Moodboards",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Moodboards_Users_UserId",
                table: "Moodboards");

            migrationBuilder.DropColumn(
                name: "Color1",
                table: "Moodboards");

            migrationBuilder.DropColumn(
                name: "Color2",
                table: "Moodboards");

            migrationBuilder.DropColumn(
                name: "Color3",
                table: "Moodboards");

            migrationBuilder.DropColumn(
                name: "Color4",
                table: "Moodboards");

            migrationBuilder.DropColumn(
                name: "Color5",
                table: "Moodboards");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Moodboards");

            migrationBuilder.RenameColumn(
                name: "TextureImageUrl",
                table: "Moodboards",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "SecondaryFontUrl",
                table: "Moodboards",
                newName: "ThumbnailUrl");

            migrationBuilder.RenameColumn(
                name: "PrimaryFontUrl",
                table: "Moodboards",
                newName: "BackgroundColorHex");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Moodboards",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Moodboards_Users_UserId",
                table: "Moodboards",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
