using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        
        public string MovieTitle { get; set; }
        // [ForeignKey("MovieTitle")]
       // public virtual Movie Movie { get; set; }
        public string ShippingName { get; set; }

        public string CardNumber { get; set; }

        public int Cvv { get; set; }
        public string ExpDate { get; set; }
        public string BillingAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string ShippingAddress { get; set; }
        public bool IsFullFilled { get; set; }
    }
}
