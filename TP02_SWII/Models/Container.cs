using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TP02_SWII.Models
{
    public class Container
    {
        [Key]
        public int Id { get; set; }
        public String Tipo { get; set; }
        public int Tamanho { get; set; }
        public BL bl { get; set; }        
        public int? BlID { get; set; }
    }
}