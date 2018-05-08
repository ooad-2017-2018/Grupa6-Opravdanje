using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekat.Models
{
    public class Korisnik : Osoba
    {
        string email;
        string username;
        string password
        DateTime datumRodjenja;
        string gradStanovanja;
        Boolean statusVerifikovan;

        public Korisnik(string email, string username, string password, DateTime datumRodjenja, string gradStanovanja, bool statusVerifikovan)
        {
            this.Email = email;
            this.Username = username;
            this.Password = password;
            this.DatumRodjenja = datumRodjenja;
            this.GradStanovanja = gradStanovanja;
            this.statusVerifikovan = statusVerifikovan;
        }

        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public string GradStanovanja { get => gradStanovanja; set => gradStanovanja = value; }
    }
}
