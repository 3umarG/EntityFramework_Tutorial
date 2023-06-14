using Inheritance.Context;
using Inheritance.Entities;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        using(InheritanceContext context = new InheritanceContext())
        {
            context.Database.Migrate();
            context.Teachers.Add(new Teacher() { FullName = "Teacher 01", Age = 35, HireDate = DateTime.Now });
            context.Students.Add(new Student() { FullName = "Student 01", Age = 18, Grade = 88 });

            //context.Students.First().FullName = "Student 01";
            //context.Students.First().Age = 20;

            //context.Teachers.First().HireDate = DateTime.Now.Date;


            context.SaveChanges();
        }
    }
}