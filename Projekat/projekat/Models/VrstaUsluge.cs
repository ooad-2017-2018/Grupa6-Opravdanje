using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekat.Models
{
    public class VrstaUsluge
    {
        int ID;
        string nazivUsluge;

        public VrstaUsluge(int iD, string nazivUsluge)
        {
            ID1 = iD;
            this.NazivUsluge = nazivUsluge;
        }

        public int ID1 { get => ID; set => ID = value; }
        public string NazivUsluge { get => nazivUsluge; set => nazivUsluge = value; }
    }
