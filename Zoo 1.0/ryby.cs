using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_1._0
{
    class ryby : zvire, Ijeryba
    {
        public int Pocetploutvi { get; set; }

        public void plave()
        {
            Console.WriteLine("ryba plave");
        }

        public ryby(string jmeno, int vek, string pohlavi, string druh, int id, int pocetploutvi) : base (jmeno, vek, pohlavi, druh, id)
        {

        }

        public ryby(string jmeno)
        {

        }

        public override void existuje()
        {
            Console.WriteLine("ryba existuje");
        }

    }
}
