using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SoftwareEssentials.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartingDate { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
    }
}
