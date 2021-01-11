using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineBookstore.Models
{
    [Table("kniga", Schema = "online_bookstore")]
    public class kniga
    {
        [Key]
        public string isbn { get; set; }
        public string naslov { get; set; }
        public int godinaizdavanje { get; set; }
        public string kategorija { get; set; }
        public string embg_izdavac { get; set; }
    }
}