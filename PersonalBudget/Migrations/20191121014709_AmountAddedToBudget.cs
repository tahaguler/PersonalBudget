using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonalBudget.Api.Migrations
{
    public partial class AmountAddedToBudget : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "Budget",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Budget");
        }
    }
}
