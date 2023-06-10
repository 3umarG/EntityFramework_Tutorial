using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping_Migration02.Entities
{
    public class Department
    {
        public int DeptID { get; set; }

        public string Name { get; set; }

        public int YearOfCreation { get; set; }

        // the name of the Navigation Property in the other side of the relation
        // it is useful when you need to change the name of the Navigation Prop. , that the Naming Convension 
        // can't understand the Relation
        [InverseProperty("Department")]
        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();


    }
}
