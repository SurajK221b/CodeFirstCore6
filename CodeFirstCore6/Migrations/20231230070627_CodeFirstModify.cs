using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstCore6.Migrations
{
    public partial class CodeFirstModify : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeeName",
                table: "Employees",
                newName: "EmployeeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeeID",
                table: "Employees",
                newName: "EmployeeName");
        }
    }
}
