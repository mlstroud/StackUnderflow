using Microsoft.EntityFrameworkCore.Migrations;

namespace StackUnderflow.Migrations
{
    public partial class PostUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ForumId",
                table: "Posts",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ForumId",
                table: "Posts");
        }
    }
}
