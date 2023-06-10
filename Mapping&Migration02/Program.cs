//using Entity01;
using Mapping_Migration02.Context;
using Mapping_Migration02.Entities;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        using (CompanyContext context = new CompanyContext())
        {
            context.Database.Migrate();
            /*
            var E = new Employee()
            {
                Name = "Ziad",
                Age = 21,
                Email = "Ziad@gmail.com",
                Salary = 220
            };

            Console.WriteLine(context.Entry(E).State);  // Detached ملوش علاقة بال context 

            context.Add(E); // Added to the Local Employees , the DB Table has no element yet !!

            Console.WriteLine(context.Entry(E).State);  // Added : to the local

            context.SaveChanges();

            Console.WriteLine(context.Entry(E).State);  // unchanged
            */

            var D1 = new Department() { Name = "IT" };
            var D2 = new Department() { Name = "HR" };

            context.Departments.Add(D1);
            context.Departments.Add(D2);

            context.SaveChanges();
        }
    }
}