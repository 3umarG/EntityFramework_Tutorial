using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping_Migration02.Entities
{
    public class Student
    {
        public int StudentId { get; set; }

        public string SName { get; set; }

        public virtual ICollection<StudentSubject> StudentSubjects { get; set; } = new HashSet<StudentSubject>();


    }
}
