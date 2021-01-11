using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineBookstore.Models
{
    public class formaKupiKniga
    {
        [Key]
        public int kosnicka_id { get; set; }
        public int primerok_id { get; set; }

        public List<kupuvacka_kosnica> kosnicka_ids { get; set; }
        public List<primerok_kniga> primerok_ids { get; set; }
        public formaKupiKniga()
        {
            kosnicka_ids = new List<kupuvacka_kosnica>();
            primerok_ids = new List<primerok_kniga>();
        }
    }
}