using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineBookstore.Models
{
    public class KnigaAvtor
    {
        [Key]
        public string naslov { get; set; }
        public string avtor { get; set; }
    }
}