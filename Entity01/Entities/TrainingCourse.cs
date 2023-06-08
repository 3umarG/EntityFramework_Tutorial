using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity01
{

    /// <summary>
    /// 4 Ways of Mapping between Classes and Tables
    /// 1- Following the EF Naming Convention : in the Employee & Department Classes
    /// 2- By using Annotations
    /// 3- Fluent API : by using OnConfiguration function in DbContext Class : handle the Mapping of all classes during the Config.
    /// 4- Configuration Classes : for every Entity(Class) we create another class for all Mapping properties
    ///    we separate the function in the OnConifguration function into several classes.
    /// </summary>
    /// 

    // Change the Table name in the DB
    [Table("Courses")]
    public class TrainingCourse
    {

        // Annotate that this is the PK
        [Key]
        public int CourseNumber { get; set; }


        // string accept null values because it is reference type , if i want to deny this
        [Required]
        // determine the nvarchar(40)
        [MaxLength(40)]
        [Column("CourseName")]
        public string Name { get; set; }


        [Column("CourseDuration")]
        public short Duration { get; set; }

        /// Many - Many Relation between TrainingCourses and Employees
        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();


    }
}
