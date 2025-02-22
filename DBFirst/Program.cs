using DBFirst.Data.Contexts;
using DBFirst.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DBFirst
{
    internal class Program
    {
        static void Main()
        {
            using NorthwindDbContext context = new NorthwindDbContext();

            //Category category = new Category
            //{
            //    CategoryName = "Hamada",
            //    Description = "Hamada Description"
            //};

            //context.Categories.Add(category);
            //context.SaveChanges();

            //var result = context.Categories.Include(C => C.Products).ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.CategoryName);
            //    Console.WriteLine();
            //    foreach (var product in item.Products)
            //    {
            //        Console.WriteLine(product.ProductName);
            //    }
            //}


            #region Run SQL Query
            ////// Run SQL Query
            ////// 1. Select Statments : FromSqlRaw(), FromSqlInterpolated()

            //////var result = context.Categories.FromSqlRaw("Select * From Categories");
            //////var result = context.Products.FromSqlRaw("Select * From Products Where UnitsInStock = 0");

            ////int price = 10;
            ////var result = context.Products.FromSqlInterpolated($"Select * From Products Where UnitPrice > {price}");

            ////foreach (var item in result)
            ////{
            ////    Console.WriteLine(item.ProductName);
            ////}

            //// 2. DML Statments [Update - Insert - Delete] : ExecuteSqlRaw(), ExecuteSqlInterpolated()

            //int id = 0;

            //context.Database.ExecuteSqlRaw("Update Products Set UnitPrice = UnitPrice * 2 Where UnitPrice > 100");
            //context.Database.ExecuteSqlInterpolated($"Delete From Products Where UnitsInStock = {id}"); 
            #endregion
        }
    }
}
