
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping_Migration02.Entities
{
    public class TeacherComputer
    {
        public int TeacherID { get; set; }

        public int ComputerID { get; set; }

        public virtual Teacher Teacher { get; set; }

        public virtual Computer Computer { get; set; }


    }
}
