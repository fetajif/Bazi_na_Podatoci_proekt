using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineBookstore.Models
{
    [Table("kupuvacka_kosnica", Schema ="online_bookstore")]
    public class kupuvacka_kosnica
    {
        [Key]
        public int kosnicka_id { get; set; }
        public string embg_korisnik { get; set; }
    }
}