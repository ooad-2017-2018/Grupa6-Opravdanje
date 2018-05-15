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

        public void DodajUFavorite(PoslovniProfil profil)
        {
            omiljeniProfili.Add(profil);
        }

        public void DodajRezervaciju(Rezervacija rezervacija)
        {
            rezervacije.Add(rezervacija);
        }
    }
}
