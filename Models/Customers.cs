using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SalseInvoice.Models
{
    public class Customers
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public int Mobile { get; set; }
        public string Address { get; set; }
    }
}