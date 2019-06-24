using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SalseInVoice00.Models
{
    public class StockEntity
    {
        [Key]
        public int id { get; set; }
        public int totalPrice { get; set; }
        public int  productQuantity{ get; set; }
       
    }
}