using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Termekek
{
    public class RohadtParadicsom : Termek, IAkciozhato
    {
        private double tomeg;
        public RohadtParadicsom(int egysegar, double tomeg) : base("rohadt paradicsom", egysegar)
        {
            this.tomeg = tomeg;
        }

        public int akcioAr()
        {
            return Convert.ToInt32(mennyibeKerul() * 0.80);
        }

        public override int mennyibeKerul()
        {
            return Convert.ToInt32(this.tomeg * this.egysegar);
        }

        public override string? ToString()
        {
            return base.ToString() + $" | {this.tomeg}kg rohadt paradicsom - {mennyibeKerul()}Ft";
        }
    }
}
