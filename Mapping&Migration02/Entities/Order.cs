using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping_Migration02.Entities
{
    // Partial : Every Order may have one payment .
    public class Order
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int Year { get; set; }

        public virtual Payment Payment { get; set; }

    }
}
