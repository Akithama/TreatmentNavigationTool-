using Microsoft.EntityFrameworkCore.Migrations;

namespace Unum.Data.Migrations
{
    public partial class AddedAnswerDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AnswerDescription",
                table: "Answers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnswerDescription",
                table: "Answers");
        }
    }
}
