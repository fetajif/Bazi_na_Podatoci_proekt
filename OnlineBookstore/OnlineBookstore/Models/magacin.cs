using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineBookstore.Models
{
    [Table("magacin", Schema ="online_bookstore")]
    public class magacin
    {
        [Key]
        public int magacin_id { get; set; }
        public string adresa { get; set; }
    }
}