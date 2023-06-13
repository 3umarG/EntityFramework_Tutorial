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

            //var D1 = new Department() { Name = "IT" };
            //var D2 = new Department() { Name = "HR" };

            //context.Departments.Add(D1);
            //context.Departments.Add(D2);

            //var P1 = new Project() { ProjectName = "P01", Year = 2019 };
            //var P2 = new Project() { ProjectName = "P02", Year = 2022 };
            //context.AddRange(P1, P2);

            #region One to One Relation Partial-Total 
            /*
            //var O3 = new Order() { Name = "Order 3", Year = 2021 };
            //var O4 = new Order() { Name = "Order 4", Year = 2018 };
            //var O5 = new Order() { Name = "Order 5", Year = 2021 };
            //var O2 = new Order() { Name = "Order 2", Year = 2022 };

            //context.Orders.AddRange(new Order[] { O3, O4, O5, O2 });
            //context.Orders.Add(O2);


            var P1 = new Payment() { Name = "Payment 1", Price = 25.5 , OrderID = 2};
            //var P2 = new Payment() { Name = "Payment 2", Price = 55, OrderID = 2 };
            //var P3 = new Payment() { Name = "Payment 3", Price = 55, OrderID = 3 };
            //var P4 = new Payment() { Name = "Payment 4", Price = 55, OrderID = 4 };
            //var P8 = new Payment() { Name = "Payment 8", Price = 55, OrderID = 8 };
            context.Payments.AddRange(P1);
            */
            #endregion


            #region One to One Relation Partial-Partial
            //var T1 = new Teacher() { Name = "Teacher 01" };
            //var T2 = new Teacher() { Name = "Teacher 02" };
            //var T3 = new Teacher() { Name = "Teacher 03" };
            //context.AddRange(T1, T2, T3);


            //var C1 = new Computer() { Version = "I7" };
            //var C2 = new Computer() { Version = "I5" };
            //var C3 = new Computer() { Version = "I2" };
            //var C4 = new Computer() { Version = "I3" };
            //context.AddRange(C1  , C2, C3 , C4);

            //context.TeachersComputers.Add(new TeacherComputer()
            //{
            //    TeacherID = 2,
            //    ComputerID = 4,
            //});

            //var tc = context.TeachersComputers.Include(TC => TC.Teacher).Include(TC => TC.Computer).ToList();
            //foreach (var teacher in tc)
            //{
            //    Console.WriteLine($"Teacher : {teacher.Teacher.Name} has Computer : {teacher.Computer.Version}");
            //}



            #endregion


            context.SaveChanges();
        }
    }
}