using Microsoft.EntityFrameworkCore.Migrations;

namespace MediatR.Web.Migrations
{
    public partial class AddedNameToProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Projects",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Projects");
        }
    }
}
