using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlannerN.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "tasks",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "BOOl",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "tasks",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "tasks",
                type: "BOOl",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "description",
                table: "tasks",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
