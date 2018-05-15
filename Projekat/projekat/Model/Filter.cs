using Windows.System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekat.Models
{
    public class Filter
    {
        string grad;
        Usluga usluga;

        public Filter(string grad, Usluga usluga)
        {
            this.Grad = grad;
            this.Usluga = usluga;
        }

        public string Grad { get => grad; set => grad = value; }
        public Usluga Usluga { get => usluga; set => usluga = value; }
    }
}
