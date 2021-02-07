using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_1._0
{
    class ptaci1 : zvire, Ijeptak
    {
        public string Barva { get; set; }
        public void leta()
        {

        }

        public ptaci1(string jmeno, int vek, string pohlavi, string druh, int id, string barva) : base (jmeno, vek, pohlavi, druh, id)
        {
            Barva = barva;
        }
    }
}
