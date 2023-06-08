using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity01
{
    public class Employee
    {

        // Naming Convenstion of Entity Framework to determine the Primary Key of the generated Table
        // ID Numeric / ClassName+ID 
        public int ID { get; set; }

        public string FName { get; set; }

        public string LName { get; set; }

        public decimal Salary { get; set; }

        public int? Age { get; set; }

        // To make a navigational prop. you can reference to the other table by using
        // 1- Numeric Prop. for ref the ID   ====> int ID
        // 2- Object Reference =====> Department Department
        // and the Navigation Prop. should be virtual modifier
        public virtual Department? Department { get; set; }

        // Many - Many Relationship
        // if the Table between the two tables of the relation doesn't have any new attributes
        // only the composite PK I can annotate by define two Collections in the two sides of relation
        // if there is another properties , i should create new class and assign them to it .
        public virtual ICollection<TrainingCourse> Courses { get; set; } = new HashSet<TrainingCourse>();
    }
}
