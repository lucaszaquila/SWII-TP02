using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TP02_SWII.Models
{
    public class BL
    {
        [Key]
        public int Id { get; set; }
        public String Consignee { get; set; }
        public String Navio { get; set; }
    }
}