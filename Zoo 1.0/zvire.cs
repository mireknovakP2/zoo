using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_1._0
{
    abstract class zvire
    {
        public string Jmeno { get; private set; }
        public int Vek { get; private set; }
        public string Pohlavi { get; private set; }
        public string Druh { get; private set; }
        private int _id {  get;  set; }

        public zvire(string jmeno, int vek, string pohlavi, string druh , int id)
        {
            Jmeno = jmeno;
            Vek = vek;
            Pohlavi = pohlavi;
            Druh = druh;
            _id = id;
        }

        public zvire()
        {
            Jmeno = "petr";
            Vek = 5;
            Pohlavi = "muž";
            Druh = "nosorožec";
            _id = 8510;
        }

        public zvire(string druh)
        {
            Jmeno = "Adam";
            Vek = 5;
            Pohlavi = "muž";
            Druh = druh;
            _id = 8510;
        }

        public zvire(int vek)
        {
            Jmeno = "petr";
            Vek = vek;
            Pohlavi = "muž";
            Druh = "nosorožec";
            _id = 8510;
        }

        public static string operator == (zvire a, zvire b)
        {
            if(a.Druh == b.Druh){
                return "stejný";
            }

            return "rozdílný";
        }

        public static string operator !=(zvire a, zvire b)
        {
            if (a.Druh != b.Druh)
            {
                return "stejný";
            }

            return "rozdílný";
        }

        public virtual void existuje()
        {
            Console.WriteLine("zvire existuje");
        }
    }
}
