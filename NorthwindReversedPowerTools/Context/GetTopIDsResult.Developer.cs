using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindReversedPowerTools.Entities
{
    public partial class GetTopIDsResult
    {
        public override string ToString()
        {
            return $"{this.CustomerID}";
        }
    }
}
