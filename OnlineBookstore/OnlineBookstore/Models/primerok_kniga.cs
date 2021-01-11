using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineBookstore.Models
{
    [Table("primerok_kniga", Schema ="online_bookstore")]
    public class primerok_kniga
    {
        [Key]
        public int primerok_id { get; set; }
        public string isbn { get; set; }
        [Required]
        public double cena { get; set; }
        public Int32? kosnicka_id { get; set; }
        [Required]
        public int magacin_id { get; set; }
    }
}