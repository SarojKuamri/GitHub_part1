using Microsoft.EntityFrameworkCore.Migrations;

namespace MyEmployeeInfo.Migrations
{
    public partial class Migrations1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "EmployeeModels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeModels",
                table: "EmployeeModels",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeModels",
                table: "EmployeeModels");

            migrationBuilder.RenameTable(
                name: "EmployeeModels",
                newName: "Employees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "EmployeeId");
        }
    }
}
