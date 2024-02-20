using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mvc_dotnet_jokepages.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingUserId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Joke",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Joke");
        }
    }
}
