using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Entities
{
    public abstract class Person
    {
        public int ID { get; set; }

        public string FullName { get; set; }

        public int Age { get; set; }

        //public bool IsEmployee { get; protected set; }

    }

    public class Teacher : Person
    {
        //public Teacher() => IsEmployee = true;
        public DateTime HireDate { get; set; }
    }

    public class Student : Person
    {
        //public Student() => IsEmployee = false;
        public decimal Grade { get; set; }

    }


}
