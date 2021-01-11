using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineBookstore.Models
{
    [Table("korisnik_koj_potrosil_najmnogu", Schema = "online_bookstore")]
    public class korisnik_potrosil_najmnogu
    {
        [Key]
        public string embg_korisnik { get; set; }
        public string korisnik { get; set; }
        public double vkupno { get; set; }
    }
}