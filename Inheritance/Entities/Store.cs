using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Entities
{
    public class Store
    {
        public int ID { get; set; }

        public string StoreName { get; set; }

        public int Rate { get; set; }

        public FullAddress FullAddress { get; set; }
    }
}
