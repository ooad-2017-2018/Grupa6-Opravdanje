using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekat.Models
{
    public class Rezervacija
    {
        DateTime datum;
        string vrijeme;
        Boolean statusUplaceno;
        Usluga usluga;
        Klijent klijent;
        PoslovniProfil pruzalacUsluge;
        Boolean statusRezervacije;

        public Rezervacija(DateTime datum, string vrijeme, bool statusUplaceno, Usluga usluga, Klijent klijent, PoslovniProfil pruzalacUsluge, bool statusRezervacije)
        {
            this.Datum = datum;
            this.Vrijeme = vrijeme;
            this.StatusUplaceno = statusUplaceno;
            this.Usluga = usluga;
            this.Klijent = klijent;
            this.PruzalacUsluge = pruzalacUsluge;
            this.StatusRezervacije = statusRezervacije;
        }

        public DateTime Datum { get => datum; set => datum = value; }
        public string Vrijeme { get => vrijeme; set => vrijeme = value; }
        public bool StatusUplaceno { get => statusUplaceno; set => statusUplaceno = value; }
        public Klijent Klijent { get => klijent; set => klijent = value; }
        public PoslovniProfil PruzalacUsluge { get => pruzalacUsluge; set => pruzalacUsluge = value; }
        public bool StatusRezervacije { get => statusRezervacije; set => statusRezervacije = value; }
        internal Usluga Usluga { get => usluga; set => usluga = value; }
    }
}
