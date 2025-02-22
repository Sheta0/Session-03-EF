using Demo_03.Contexts;
using Demo_03.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using EFDemo03DbContext context = new EFDemo03DbContext();

            #region Loading Navigational Properties
            //var departments = new List<Department>()
            //{
            //    new Department { Name = "HR" },
            //    new Department { Name = "PR" },
            //    new Department { Name = "IT" }
            //};

            //var employees = new List<Employee>()
            //{
            //    new Employee { Name = "Ahmed Ali", Salary = 11_000, Address = "Cairo", Age = 21, DeptId = 100},
            //    new Employee { Name = "Haerin", Salary = 12_000, Address = "Alex", Age = 19, DeptId = 100},
            //    new Employee { Name = "Hanni", Salary = 13_000, Address = "Giza", Age = 24, DeptId = 100 },
            //    new Employee { Name = "Omar", Salary = 17_000, Address = "Nasr City", Age = 30, DeptId = 200 },
            //    new Employee { Name = "Mariam", Salary = 16_000, Address = "Alex", Age = 22, DeptId = 200 },
            //    new Employee { Name = "Maha", Salary = 15_000, Address = "Cairo", Age = 27, DeptId = 300 },
            //    new Employee { Name = "Mohamed", Salary = 14_000, Address = "Alex", Age = 23, DeptId = 100 },
            //};

            //context.Departments.AddRange(departments);
            //context.Employees.AddRange(employees);

            //context.SaveChanges();

            //var emp = context.Employees.FirstOrDefault(E => E.Id == 10);

            //Console.WriteLine(emp?.Id ?? 0);
            //Console.WriteLine(emp?.Name ?? "NA");
            //Console.WriteLine(emp?.Salary ?? 0);
            //Console.WriteLine(emp?.Address ?? "NA");
            //Console.WriteLine(emp?.HiringDate ?? DateTime.Now);
            //Console.WriteLine(emp?.DeptId ?? 0);
            //Console.WriteLine(emp?.WorkFor?.Name ?? "NA");

            //var dept = context.Departments.FirstOrDefault(D => D.Id == 100);

            //Console.WriteLine(dept.Name);

            //foreach (var employee in dept.Employees)
            //{
            //    Console.WriteLine(employee.Name);
            //}

            //// EFCore Doesn't Load any Navigational Property


            //// EFCore Loading Navigational Properties 
            //// 1. Explicit Loading
            //// 2. Eager Loading
            //// 3. Lazy Loading


            #region 1. Explicit Loading
            //// 1. Explicit Loading 

            ////var emp = context.Employees.FirstOrDefault(E => E.Id == 10);

            ////context.Entry(emp).Reference(E => E.WorkFor).Load(); // Explicit Loading

            ////Console.WriteLine(emp?.Id ?? 0);
            ////Console.WriteLine(emp?.Name ?? "NA");
            ////Console.WriteLine(emp?.Salary ?? 0);
            ////Console.WriteLine(emp?.Address ?? "NA");
            ////Console.WriteLine(emp?.HiringDate ?? DateTime.Now);
            ////Console.WriteLine(emp?.DeptId ?? 0);
            ////Console.WriteLine(emp?.WorkFor?.Name ?? "NA");

            //var dept = context.Departments.FirstOrDefault(D => D.Id == 100);

            //context.Entry(dept).Collection(D => D.Employees).Load(); // Explicit Loading

            //Console.WriteLine(dept.Name);

            //foreach (var employee in dept.Employees)
            //{
            //    Console.WriteLine(employee.Name);
            //} 
            #endregion

            #region 2. Eager Loading
            //// 2. Eager Loading

            ////var emp = context.Employees.Include(E => E.WorkFor).FirstOrDefault(E => E.Id == 10);

            ////Console.WriteLine(emp?.Id ?? 0);
            ////Console.WriteLine(emp?.Name ?? "NA");
            ////Console.WriteLine(emp?.Salary ?? 0);
            ////Console.WriteLine(emp?.Address ?? "NA");
            ////Console.WriteLine(emp?.HiringDate ?? DateTime.Now);
            ////Console.WriteLine(emp?.DeptId ?? 0);
            ////Console.WriteLine(emp?.WorkFor?.Name ?? "NA");

            //var dept = context.Departments.Include(D => D.Employees)/*.Include(D =>D.Id)*//*.ThenInclude(E => E.Id)*/.FirstOrDefault(D => D.Id == 100);

            //Console.WriteLine(dept.Name);

            //foreach (var employee in dept.Employees)
            //{
            //    Console.WriteLine(employee.Name);
            //} 
            #endregion

            #region 3. Lazy Loading
            // 3. Lazy Loading
            // 3.1. Install Microsoft.EntityFrameworkCore.Proxies
            // 3.2. Update OnConfiguring(), UseLazyLoadingProxies
            // 3.3. Make all Entites Public 
            // 3.4. Make all Navigational Properties Virtual


            ////var emp = context.Employees.FirstOrDefault(E => E.Id == 10);

            ////Console.WriteLine(emp?.Id ?? 0);
            ////Console.WriteLine(emp?.Name ?? "NA");
            ////Console.WriteLine(emp?.Salary ?? 0);
            ////Console.WriteLine(emp?.Address ?? "NA");
            ////Console.WriteLine(emp?.HiringDate ?? DateTime.Now);
            ////Console.WriteLine(emp?.DeptId ?? 0);
            ////Console.WriteLine(emp?.WorkFor?.Name ?? "NA");

            //var dept = context.Departments.Include(D => D.Employees)/*.Include(D =>D.Id)*//*.ThenInclude(E => E.Id)*/.FirstOrDefault(D => D.Id == 100);

            //Console.WriteLine(dept.Name);

            //foreach (var employee in dept.Employees)
            //{
            //    Console.WriteLine(employee.Name);
            //} 
            #endregion
            #endregion

            #region Join Operators - Join inner
            //// Join Operators - Join inner

            /* 
             Select E.Id, E.Name, D.Id, D.Name
             From Employee E, Department D
             where D.Id = E.DeptId --Pk = Fk
            */

            //// Fluent Syntax
            //var result = context.Employees.Join(context.Departments, E => E.DeptId, D => D.Id, (E, D) => new
            //{
            //    EmpId = E.Id,
            //    EmpName = E.Name,
            //    DeptId = D.Id,
            //    DeptName = D.Name
            //}).Where(E => E.DeptName == "HR");

            //// Query Expression

            //result = from E in context.Employees
            //         join D in context.Departments
            //         on E.Id equals D.Id
            //         where D.Name == "HR"
            //         select new
            //         {
            //             EmpId = E.Id,
            //             EmpName = E.Name,
            //             DeptId = D.Id,
            //             DeptName = D.Name
            //         };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Tracking VS NoTracking
            //// Tracking vs NoTracking

            //var result = context.Employees.AsNoTracking().FirstOrDefault(E => E.Id == 10);

            //Console.WriteLine(context.Entry(result).State);

            //result.Name = "Ali";

            //Console.WriteLine(context.Entry(result).State);

            //Console.WriteLine(result.Name);

            //context.SaveChanges(); 
            #endregion

            #region Local VS Remote
            //// Local VS Remote

            ////// Remotely
            ////context.Employees.Any();
            ////context.Employees.Any();
            ////context.Employees.Any();
            ////context.Employees.Any();
            ////context.Employees.Any();
            ////context.Employees.Any();
            ////context.Employees.Any();
            ////context.Employees.Any();
            ////context.Employees.Any();
            ////context.Employees.Any();
            ////context.Employees.Any();
            ////context.Employees.Any();

            //// Local
            //context.Employees.Load();

            //context.Employees.Local.Any();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any(); 
            #endregion

            #region View
            //var result = context.EmployeeDepartments.FromSqlRaw("Select * From EmployeeDepartmentView");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
        }
    }
} 
