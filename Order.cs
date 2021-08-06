using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    public class Order : Customer
    {
        [Key]
        public string CustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        public string Title { get; set; }

        public override string ToString()
        {
            return "Customer " + CustomerId + "ordered " + Title + "at " + OrderDate;
        }
    }
}
