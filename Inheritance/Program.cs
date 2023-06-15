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

            #region TPH : DbSets for every Entity
            //context.Teachers.Add(new Teacher() { FullName = "Teacher 01", Age = 35, HireDate = DateTime.Now });
            //context.Students.Add(new Student() { FullName = "Student 01", Age = 18, Grade = 88 });

            //context.Students.First().FullName = "Student 01";
            //context.Students.First().Age = 20;

            //context.Teachers.First().HireDate = DateTime.Now.Date;
            #endregion


            #region DbSet for only one hirarechy
            //context.Add(new Teacher() { FullName = "Teacher 02", Age = 65, HireDate = new DateTime(2020, 5, 30) });
            //context.Add(new Student() { FullName = "Student 02", Age = 22, Grade = 97 });

            foreach (var student in context.People.OfType<Student>())
            {
                Console.WriteLine($"Student : {student.FullName} with Grade : {student.Grade}");
            }
            Console.WriteLine("\n");
            foreach (var teacher in context.People.OfType<Teacher>())
            {
                Console.WriteLine($"Teacher : {teacher.FullName} with Grade : {teacher.Age}");
            }

            #endregion

            context.SaveChanges();
        }
    }
}