using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping_Migration02.Entities
{
    // Total : Every Payment should be associated to one order
    // the Total side should have the PK of the partial side as Foreign Key
    public class Payment
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        // Reference
        public virtual Order Order { get; set; }

        // FK 
        public int OrderID { get; set; }





    }
}
