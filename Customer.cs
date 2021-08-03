using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int CustomerId{ get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string CardNumber { get; set; }

        public int Cvv { get; set; }
        public string ExpDate { get; set; }

        public string Address{ get; set; }

        public string PhoneNumber { get; set; }

        

    }
}
