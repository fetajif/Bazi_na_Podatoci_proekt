using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineBookstore.Models
{
    public class smestiZaliha
    {
        [Key]
        public int magacin_id { get; set; }
        public int primerok_id { get; set; }

        public List<magacin> magacini { get; set; }
        public List<primerok_kniga> primeroci { get; set; }
        public smestiZaliha()
        {
            magacini = new List<magacin>();
            primeroci = new List<primerok_kniga>();
        }
    }
}