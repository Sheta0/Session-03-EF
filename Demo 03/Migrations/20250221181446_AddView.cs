using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo_03.Migrations
{
    /// <inheritdoc />
    public partial class AddView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"Create or Alter View EmployeeDepartmentView as 
                                       Select E.Id, E.EmpName, D.DeptName
                                       From Employees E Join Departments D
                                       on D.Id = E.DeptId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"Drop View EmployeeDepartmentView");
        }
    }
}
