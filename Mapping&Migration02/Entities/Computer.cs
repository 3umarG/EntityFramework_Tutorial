using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping_Migration02.Entities
{
    public class Computer
    {
        public int ID { get; set; }

        public string Version { get; set; }

        public virtual TeacherComputer TeacherComputer { get; set; }


    }
}
