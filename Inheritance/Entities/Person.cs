using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Entities
{
    public class Person
    {
        public int ID { get; set; }

        public string FullName { get; set; }

        public int Age { get; set; }

    }

    public class Teacher : Person
    {
        public DateTime HireDate { get; set; }
    }

    public class Student : Person
    {
        public decimal Grade { get; set; }

    }


}
