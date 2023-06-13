using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping_Migration02.Entities
{
    public class Teacher
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public virtual TeacherComputer TeacherComputer { get; set; }

    }
}
