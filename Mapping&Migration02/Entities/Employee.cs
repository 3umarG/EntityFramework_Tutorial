using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping_Migration02.Entities
{
    public class Employee
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public double Salary { get; set; }

        [Range(19, 99)]
        public int? Age { get; set; }

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        //  that's make the CASCADE property when update or delete
        [ForeignKey("Department")]
        public int DeptID { get; set; }

        [InverseProperty("Employees")]
        public virtual Department Department { get; set; }
    }
}
