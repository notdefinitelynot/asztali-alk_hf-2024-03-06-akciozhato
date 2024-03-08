using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Termekek
{
    public class Salata : Termek
    {
        private int darab;


        public Salata(int egysegar ,int darab) : base("salata", egysegar)
        {
            this.darab = darab;
        }

        public override int mennyibeKerul()
        {
            return this.darab * this.egysegar;
        }

        public override string? ToString()
        {
            return base.ToString() + $" | {darab} db salata - {mennyibeKerul()}Ft";
        }
    }
}
