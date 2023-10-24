using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solsys
{
    internal class Bolygo
    {
        public string Nev { get; set; }
        public int HoldSzam { get; set; }
        public double TerfogatArany { get; set; }

        public Bolygo(string sor)
        {
            var v = sor.Split(';');
            this.Nev = v[0];
            this.HoldSzam = int.Parse(v[1]);
            this.TerfogatArany = double.Parse(v[2]);
        }
    }
}
