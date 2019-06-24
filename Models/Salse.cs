using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SalseInVoice00.Models
{
    public class Salse
    {
        [Key]
        public int id { get; set; }
        public string customer { get; set; }
        public string product { get; set; }
    }
}