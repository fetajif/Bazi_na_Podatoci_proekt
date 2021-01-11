using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineBookstore.Models
{
    [Table("najprodadena_kniga", Schema ="online_bookstore")]
    public class NajprodadenaKniga
    {
        [Key]
        public string naslov { get; set; }
        public string avtor { get; set; }
        public int max_br { get; set; }
    }
}