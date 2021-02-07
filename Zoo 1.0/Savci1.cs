using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_1._0
{
    class Savci1 : zvire, Ijesavec
    {
        public int Pocetnohou { get; set; }

        public void zije()
        {

        }

        public Savci1(string jmeno, int vek, string pohlavi, string druh, int id, int pocetnohou) : base(jmeno, vek, pohlavi, druh, id)
        {
            Pocetnohou = pocetnohou;
        }
    }
}
