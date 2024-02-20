using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mvc_dotnet_jokepages.Data.Migrations
{
    /// <inheritdoc />
    public partial class relationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Joke",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Joke_UserId",
                table: "Joke",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Joke_AspNetUsers_UserId",
                table: "Joke",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Joke_AspNetUsers_UserId",
                table: "Joke");

            migrationBuilder.DropIndex(
                name: "IX_Joke_UserId",
                table: "Joke");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Joke",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
