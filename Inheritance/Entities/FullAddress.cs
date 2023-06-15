using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Entities
{
    /// <summary>
    /// What is Owned Entity ??
    /// - It is Entity that holds complex types like FullName , FullAddress 
    /// - to avoid repeating these columns if I use them in more than one Table/Entity "Reusability"
    /// 
    /// - I can map it to DB to Multi Columns in the Table , or to a single column and use FK for the owned Table
    /// </summary>
    [Owned]
    public class FullAddress
    {
        [Required]
        [StringLength(100)]
        public string FirstAddress { get; set; }

        [Required]
        [StringLength(100)]
        public string SecondAddress { get; set; }

        [StringLength(100)]
        public string ThirdAddress { get; set; }

        [Required]
        [StringLength(100)]
        public string ZipCode { get; set; }

        [StringLength(4, MinimumLength = 4)]
        public string CountryCode { get; set; }
    }
}
