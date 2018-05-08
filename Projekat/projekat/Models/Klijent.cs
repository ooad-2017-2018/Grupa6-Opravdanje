using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekat.Models
{
    public class Klijent : Korisnik
    {
        List<PoslovniProfil> omiljeniProfili;
        List<Rezervacija> rezervacije;

        public Klijent()
        {
            omiljeniProfili = new List<PoslovniProfil>();
            rezervacije = new List<Rezervacija>();
        }

        public DodajUFavorite(PoslovniProfil profil)
        {
            omiljeniProfili.Add(profil);
        }

        public DodajRezervaciju(Rezervacija rezervacija)
        {
            rezervacije.Add(Rezervacija);
        }
    }
}
