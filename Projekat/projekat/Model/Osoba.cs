using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekat.Models
{
    public class Osoba
    {
        Int32 ID;
        string ime;
        string prezime;

        public Osoba()
        {
        }

        public Osoba(int iD, string ime, string prezime)
        {
            ID1 = iD;
            this.Ime = ime;
            this.Prezime = prezime;
        }

        public int ID1 { get => ID; set => ID = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
    }
}
