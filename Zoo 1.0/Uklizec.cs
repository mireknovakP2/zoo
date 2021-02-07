using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_1._0
{
    class Uklizec : Zamestnanec
    {

        public string Sektor { get; protected set; }

        public Uklizec (string jmeno, string primeni, string pohlavi, int vek, string sektor) : base (jmeno, primeni, pohlavi, vek)
        {
            Sektor = sektor;
        }
    }
}
