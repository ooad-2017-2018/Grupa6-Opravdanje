using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekat.Models
{
    public class PoslovniProfil : Korisnik
    {
        string adresa;
        Boolean statusLicaVerifikovan;
        List<Slika> slike;
        List<Rezervacija> rezervacije;
        int brojZaposlenih;

        public PoslovniProfil(string adresa, bool statusLicaVerifikovan, List<Slika> slike, int brojzaposlenih)
        {
            this.Adresa = adresa;
            this.StatusLicaVerifikovan = statusLicaVerifikovan;
            this.slike = new List<Slika>();
            this.slike = slike;
            rezervacije = new List<Rezervacija>();
            BrojZaposlenih = brojzaposlenih;
        }

        public string Adresa { get => adresa; set => adresa = value; }
        public bool StatusLicaVerifikovan { get => statusLicaVerifikovan; set => statusLicaVerifikovan = value; }
        public int BrojZaposlenih { get => brojZaposlenih; set => brojZaposlenih = value; }
    }
}
