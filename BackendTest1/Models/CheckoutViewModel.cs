using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackendTest1.Models
{
    public class CheckoutViewModel
    {
        [Required(ErrorMessage = "First name is required")]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        public String LastName { get; set; }

        [Required(ErrorMessage = "Address name is required")]
        public String Address { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [Phone]
        public String Phone { get; set; }

        public String PaymentMethod { get; set; }
    }
}
