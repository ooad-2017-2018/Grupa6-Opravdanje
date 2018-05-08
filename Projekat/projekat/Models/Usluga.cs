using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekat.Models
{
    public class Usluga
    {
        int idVrsteUsluge;
        double cijena;
        double trajanjeUsluge;

        public Usluga(int idVrsteUsluge, double cijena, double trajanjeUsluge)
        {
            this.IdVrsteUsluge = idVrsteUsluge;
            this.Cijena = cijena;
            this.TrajanjeUsluge = trajanjeUsluge;
        }

        public int IdVrsteUsluge { get => idVrsteUsluge; set => idVrsteUsluge = value; }
        public double Cijena { get => cijena; set => cijena = value; }
        public double TrajanjeUsluge { get => trajanjeUsluge; set => trajanjeUsluge = value; }
    }
}
