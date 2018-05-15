using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekat.Models
{
    public class PravnoLice : PoslovniProfil
    {
        string IDLica;

        public string IDLica1 { get => IDLica; set => IDLica = value; }

        public PravnoLice(string iDLica)
        {
            IDLica = iDLica;
        }
    }
}
