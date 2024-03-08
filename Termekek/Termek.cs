using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Termekek
{
    public abstract class Termek
    {
        private string nev;
        protected int egysegar;

        public Termek(string nev, int egysegar)
        {
            this.nev = nev;
            this.egysegar = egysegar;
        }

        public abstract int mennyibeKerul();

        public override string? ToString()
        {
            return $"{this.nev} - {mennyibeKerul()}Ft";
        }
    }



}
