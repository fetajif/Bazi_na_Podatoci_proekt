using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineBookstore.Models
{
    [Table("pogled_kniga_avtori", Schema = "online_bookstore")]
    public class pogled_kniga_avtori
    {
        [Key]
        public string isbn { get; set; }
        public string naslov { get; set; }
        public int godinaizdavanje { get; set; }
        public string kategorija { get; set; }
        public string embg_avtor { get; set; }
        public string avtor { get; set; }
        public string adresa { get; set; }
    }
}