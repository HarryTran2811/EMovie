using Microsoft.EntityFrameworkCore.Migrations;

namespace EMovie.Migrations
{
    public partial class UpdateMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TrailerURL",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrailerURL",
                table: "Movies");
        }
    }
}
