using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainningManagerService.Migrations
{
    public partial class PlanExtension : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TrainningGoal",
                table: "Plans",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PlanBodyArea",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    BodyArea = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false),
                    PlanId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanBodyArea", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanBodyArea_Plans_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plans",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_PlanBodyArea_PlanId",
                table: "PlanBodyArea",
                column: "PlanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlanBodyArea");

            migrationBuilder.DropColumn(
                name: "TrainningGoal",
                table: "Plans");
        }
    }
}
