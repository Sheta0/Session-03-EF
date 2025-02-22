using InheritanceExample.Contexts;
using InheritanceExample.Models;

namespace InheritanceExample
{
    internal class Program
    {
        static void Main()
        {
            // 3 Ways to Generate Schema
            // 1. TPC : Table Per Class
            // 2. TPH : Table Per Hierarchy
            // 3. TPCC : Table Per Concrete Class

            using InheritDbContext context = new InheritDbContext();

            //FullTimeEmployee fullTime = new FullTimeEmployee()
            //{
            //    Name = "Ahmed Ali",
            //    Address = "Cairo",
            //    Email = "theimpossible000@gmail.com",
            //    Salary = 12_000
            //};

            //FullTimeEmployee fullTime02 = new FullTimeEmployee()
            //{
            //    Name = "Haerin",
            //    Address = "Alex",
            //    Email = "Haerin111@gmail.com",
            //    Salary = 14_000
            //};


            //FullTimeEmployee fullTime03 = new FullTimeEmployee()
            //{
            //    Name = "Hanni",
            //    Address = "Giza",
            //    Email = "Hanni222@gmail.com",
            //    Salary = 15_000
            //};

            //context.Employees.AddRange(new[] { fullTime, fullTime02, fullTime03 });
            //context.SaveChanges();

            //PartTimeEmployee partTime = new PartTimeEmployee()
            //{
            //    Name = "Khaled Saed",
            //    Address = "Cairo",
            //    Email = "Khaled@gmail.com",
            //    HourRate = 100,
            //    NumberOfHours = 120,
            //};

            //PartTimeEmployee partTime02 = new PartTimeEmployee()
            //{
            //    Name = "Rose",
            //    Address = "Alex",
            //    Email = "Rose1@gmail.com",
            //    NumberOfHours = 200,
            //    HourRate = 300
            //};


            //PartTimeEmployee partTime03 = new PartTimeEmployee()
            //{
            //    Name = "Jisoo",
            //    Address = "Giza",
            //    Email = "Blisso@gmail.com",
            //    NumberOfHours = 129,
            //    HourRate = 80
            //};



            //context.Employees.AddRange(new[] { partTime, partTime02, partTime03 });
            //context.SaveChanges(); // Remotely

            //foreach (var employee in context.Employees.OfType<PartTimeEmployee>())
            //{
            //    System.Console.WriteLine(employee.Name);
            //}

            //var result = context.FullTimeEmployees.FirstOrDefault(E => E.Id == 1);

            //Console.WriteLine(result.Name);

        }
    }
}
