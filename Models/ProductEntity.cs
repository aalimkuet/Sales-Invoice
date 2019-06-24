using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SalseInVoice00.Models
{
    public class ProductEntity
    {
        [Key]
        public int id { get; set; }
        public string ProductName { get; set; }
        public int productPrice  { get; set; }
    }
}