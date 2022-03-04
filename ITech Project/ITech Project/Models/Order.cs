using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ITech_Project.Enums;
using Microsoft.AspNetCore.Identity;

namespace ITech_Project.Models
{
    public class Order
    {
        public int Id { get; set; }

        [DataType(DataType.Currency)]
        public int Freight { get; set; }

        public DateTime Timestamp { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public IdentityUser User { get; set; }

        public string Email { get; set; }

        [Display(Name = "Customer")]
        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Required(ErrorMessage = "Payment Is Required")]
        public Payment Payment { get; set; }

        [Required(ErrorMessage = "Shipper Is Required")]
        public Shipper Shipper { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

    }
}
