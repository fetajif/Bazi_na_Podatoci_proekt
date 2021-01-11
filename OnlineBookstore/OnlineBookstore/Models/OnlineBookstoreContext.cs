using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineBookstore.Models
{
    public class OnlineBookstoreContext : DbContext
    {

        public OnlineBookstoreContext() : base("OnlineBookstore")
        {

        }

        public DbSet<covek> covek { get; set; }

        public DbSet<avtor> avtor { get; set; }

        public DbSet<korisnik> korisniks { get; set; }

        public DbSet<kupuvacka_kosnica> Kupuvacka_Kosnicas { get; set; }

        public DbSet<magacin> Magacins { get; set; }

        public DbSet<kniga> Knigi { get; set; }

        public DbSet<e_avtor_na> E_Avtor_Na { get; set; }

        public System.Data.Entity.DbSet<OnlineBookstore.Models.KnigaAvtor> KnigaAvtors { get; set; }

        public DbSet<primerok_kniga> Primerok_Kniga { get; set; }

        public DbSet<pogled_kniga_avtori> pogled_Kniga_Avtori { get; set; }
        
        public DbSet<pogled_kupeni_knigi> pogled_Kupeni_Knigi { get; set; }

        public DbSet<vkupno_potrosil_korisnik> vkupno_Potrosil_Korisnik { get; set; }

        public DbSet<NajprodadenaKniga> NajprodadenaKniga { get; set; }

        public DbSet<korisnik_potrosil_najmnogu> Korisnik_Potrosil_Najmnogu { get; set; }
    }
}