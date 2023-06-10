using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping_Migration02.Entities
{
    public class Subject
    {
        public int SubjectId { get; set; }

        public string SubName { get; set; }

        public virtual ICollection<StudentSubject> StudentSubjects { get; set; } = new HashSet<StudentSubject>();

    }
}
