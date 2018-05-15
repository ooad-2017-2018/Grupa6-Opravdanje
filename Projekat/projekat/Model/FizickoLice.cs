using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekat.Models
{
    public class fizickoLice : PoslovniProfil
    {
        Boolean dolazakNaAdresu;

        public fizickoLice(bool dolazakNaAdresu)
        {
            DolazakNaAdresu = dolazakNaAdresu;
        }

        public bool DolazakNaAdresu { get => dolazakNaAdresu; set => dolazakNaAdresu = value; }
    }
}
