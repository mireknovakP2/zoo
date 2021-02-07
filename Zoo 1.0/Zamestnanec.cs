using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_1._0
{
    abstract class Zamestnanec
    {

        public string Jmeno { get; protected set; }
        public string Prijmeni { get; protected set; }
        public string Pohlavi { get; protected set; }
        public int Vek { get; protected set; }

        public Zamestnanec (string jmeno, string primeni, string pohlavi, int vek)
        {
            Jmeno = jmeno;
            Prijmeni = primeni;
            Pohlavi = pohlavi;
            Vek = vek;
        }
    }
}
