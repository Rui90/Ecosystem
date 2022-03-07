using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainningManagerService.Migrations
{
    public partial class PlanChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DurationInSeconds",
                table: "Plans");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "DurationInSeconds",
                table: "Plans",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
