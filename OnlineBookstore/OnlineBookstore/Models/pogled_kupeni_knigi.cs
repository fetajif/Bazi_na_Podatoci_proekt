using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineBookstore.Models
{
    [Table("pogled_kupeni_knigi", Schema ="online_bookstore")]
    public class pogled_kupeni_knigi
    {
        [Key]
        public string isbn { get; set; }
        public string naslov { get; set; }
        public double cena { get; set; }
        public int godinaizdavanje { get; set; }
        public string kategorija { get; set; }
        public string embg_avtor { get; set; }
        public string avtor { get; set; }
        public string adresa_avtor { get; set; }
        public string email_korisnik { get; set; }
        public string korisnik { get; set; }
        public string adresa_korisnik { get; set; }
    }
}