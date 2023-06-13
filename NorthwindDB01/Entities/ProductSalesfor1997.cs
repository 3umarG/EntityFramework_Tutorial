using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDB01.Entities
{

    /// <summary>
    /// DTO : for View
    /// </summary>
    [Keyless]
    public class ProductSalesfor1997
    {
        public string CategoryName { get; set; }

        public string ProductName { get; set; }

        public decimal ProductSales { get; set; }


    }
}
