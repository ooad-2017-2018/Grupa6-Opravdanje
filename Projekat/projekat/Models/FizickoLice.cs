using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekat.Models
{
    public class FizickoLice : PoslovniProfil
    {
        Boolean dolazakNaAdresu;

        public FizickoLice(bool dolazakNaAdresu)
        {
            this.DolazakNaAdresu = dolazakNaAdresu;
        }

        public bool DolazakNaAdresu { get => dolazakNaAdresu; set => dolazakNaAdresu = value; }
    }
}
