using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_1._0
{
    class Zverolekar: Zamestnanec
    {
        public int Roky_praxe { get; protected set; }
        public zvire Specializace { get; protected set; }
        

        public Zverolekar(string jmeno, string primeni, string pohlavi, int vek, int roky_praxe, zvire specializace) : base(jmeno, primeni, pohlavi, vek)
        {
            Roky_praxe = roky_praxe;
            Specializace = specializace;
        }



    }
}
