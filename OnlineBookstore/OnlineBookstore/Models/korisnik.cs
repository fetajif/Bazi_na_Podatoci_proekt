using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineBookstore.Models
{
    [Table("korisnik", Schema ="online_bookstore")]
    public class korisnik
    {
        [Key]
        public string embg_korisnik { get; set; }
        public string email { get; set; }
        public string lozinka { get; set; }
        public string korisnicko_ime { get; set; }
    }
}