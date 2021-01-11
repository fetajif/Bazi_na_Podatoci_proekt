using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineBookstore.Models
{
    [Table("vkupno_potrosil_korisnik", Schema = "online_bookstore")]
    public class vkupno_potrosil_korisnik
    {
        [Key, Column(Order = 1)]
        public string korisnik { get; set; }
        [Key, Column(Order = 2)]
        public double vkupno_potroseno { get; set; }
        public int broj_knigi { get; set; }
    }
}