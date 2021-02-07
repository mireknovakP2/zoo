using System;

namespace Zoo_1._0
{
    class Program
    {
        static void Main(string[] args)
        {

            //ahoj
            Savci1 jelen = new Savci1("michal", 10 , "samec", "jelen_lesní", 3220, 4);

            Console.WriteLine(jelen.Jmeno);
            Console.WriteLine(jelen.Vek);
            Console.WriteLine(jelen.Pohlavi);
            Console.WriteLine(jelen.Druh);

            Console.WriteLine("---------------------------------------");

            ryby pstruh = new ryby("aleš", 5, "samec", "pstruh", 5003, 4);

            Console.WriteLine("---------------------------------------");

            Zverolekar matěj = new Zverolekar("Matěj", "Novotný", "muž", 45, 20, pstruh);

            Console.WriteLine(matěj.Jmeno);
            Console.WriteLine(matěj.Prijmeni);
            Console.WriteLine(matěj.Pohlavi);
            Console.WriteLine(matěj.Vek);
            Console.WriteLine(matěj.Roky_praxe);
            Console.WriteLine(matěj.Specializace.Jmeno);
            Console.WriteLine(matěj.Specializace.Vek);
            Console.WriteLine(matěj.Specializace.Pohlavi);
            Console.WriteLine(matěj.Specializace.Druh);

            Console.WriteLine("---------------------------------------");

            Uklizec ondra = new Uklizec("Ondra", "krejcar", "muž", 30, "výběh slonů");

            Console.WriteLine(ondra.Jmeno);
            Console.WriteLine(ondra.Prijmeni);
            Console.WriteLine(ondra.Pohlavi);
            Console.WriteLine(ondra.Vek);
            Console.WriteLine(ondra.Sektor);


            zvire kapr = new ryby("adam");
            kapr.existuje();
        }
    }
}
