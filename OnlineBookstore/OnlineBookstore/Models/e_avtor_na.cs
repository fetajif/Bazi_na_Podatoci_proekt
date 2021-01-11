using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineBookstore.Models
{
    [Table("e_avtor_na", Schema ="online_bookstore")]
    public class e_avtor_na
    {
        [Key, Column(Order = 1)]
        public string isbn { get; set; }
        [Key, Column(Order = 2)]
        public string embg_avtor { get; set; }
    }
}