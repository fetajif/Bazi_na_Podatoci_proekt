using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineBookstore.Models
{
    [Table("avtor", Schema ="online_bookstore")]
    public class avtor
    {
        [Key]
        public string embg_avtor { get; set; }
        public string url { get; set; }
    }
}