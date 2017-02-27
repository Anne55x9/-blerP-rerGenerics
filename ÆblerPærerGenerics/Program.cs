using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÆblerPærerGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Varebeholdning af Æbler

            //var æbleBeholdning = new List<Æbler>();
            //æbleBeholdning.Add(new Æbler() { Navn = "Ingrid Marie", Lager = 50, Pris = 20.0M });
            //æbleBeholdning.Add(new Æbler() { Navn = "Cox Orange", Lager = 25, Pris = 10.0M });
            //æbleBeholdning.Add(new Æbler() { Navn = "Gråsten", Lager = 10, Pris = 22.0M });
            //æbleBeholdning.Add(new Æbler() { Navn = "Guldborg", Lager = 100, Pris = 9.0M });
            //æbleBeholdning.Add(new Æbler() { Navn = "LøgÆble", Lager = 4, Pris = 5.0M });

            //foreach (var item in æbleBeholdning)
            //{
            //    Console.WriteLine($"Navn {item.Navn} pris {item.Pris}");
            //}

            

            //Console.WriteLine("Efter sortering på pris.");

            //æbleBeholdning.Sort();

            //foreach (var item in æbleBeholdning)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //Console.WriteLine("Efter sortering på lager:");

            //æbleBeholdning.Sort(Æbler.sortLagerDescending());

            //foreach (var item in æbleBeholdning)
            //{
            //    Console.WriteLine(item.ToString());
            //}


            //var pærerBeholdning = new List<Pærer>();
            //pærerBeholdning.Add(new Pærer() { Navn = "Conference", Lager = 75M, Pris = 5M });
            //pærerBeholdning.Add(new Pærer() { Navn = "Concorde", Lager = 33M, Pris = 12M });
            //pærerBeholdning.Add(new Pærer() { Navn = "Glorød Williams", Lager = 10, Pris = 15M });
            //pærerBeholdning.Add(new Pærer() { Navn = "Noveau Poiteau", Lager = 5M, Pris = 22M });
            //pærerBeholdning.Add(new Pærer() { Navn = "Tongre", Lager = 7M, Pris = 21M });


            //decimal værdiTotalÆbler = FrugtHandler.CalculateSumÆbler(æbleBeholdning);
            //Console.WriteLine("Så meget er æblebeholdningen værd : " + værdiTotalÆbler );

            //decimal værdiTotalPærer = FrugtHandler.CalculateSumPærer(pærerBeholdning);
            //Console.WriteLine("Så meget er pærerbeholdningen værd: " + værdiTotalPærer);


            Console.WriteLine("Her starter Equals Metode opgaven:");

            //Opagev 1 - Reference and equality

            //Opgave 1.:

            var æble1 = new Æbler() { Navn = "Cox Orange", Lager = 22, Pris = 10.0M };
            var æble2 = new Æbler() { Navn = "Cox Orange", Lager = 22, Pris = 10.0M };

            //Opgave 2.:

            Console.WriteLine(æble1.Equals(æble2));
            Console.WriteLine("æble 1 equals æble 2: " + æble1.Equals(æble2));

            //Opgave 3.:

            Æbler æble3 = æble2;

            //Opgave 4.:

            Console.WriteLine("æble 2 equals æble 3: " + æble2.Equals(æble3));

            //opgave 8: Test på typen æbler eller null eller andet(Pærer).

            Console.WriteLine("Tester på hvilken type jeg initierer. Er det æble er det true, andet er false");

            var æbleType1 = new Æbler() {Navn = "Sofie", Lager = 2, Pris = 15.0M};
            var æbleType2 = new Æbler() {Navn = "Sofie", Lager = 2, Pris = 15.0M};
            var pæreType1 = new Pærer() {Navn = "Sofie", Lager = 2, Pris = 15.0M};
            var æbleType3 = new Æbler() {Navn = "Sofie", Lager = 2, Pris = 15.0M};
            æbleType3 = null;

            Console.WriteLine("Jeg sammenlignes med et æble: " + æbleType1.Equals(æbleType2));
            Console.WriteLine("Jeg sammenlignes med et æble: " + æbleType1.Equals(pæreType1));
            Console.WriteLine("Jeg sammenlignes med et æble: " + æbleType1.Equals(æbleType3));

            Console.WriteLine("Opgave 3 i Equals Metode opgaven.");
            //Opgave 3.

            //Opgave 1 Prøv med forskellige æble objekter og tjek de er ens eller ej med equal metoden:

            var æble4 = new Æbler() { Navn = "Cox Orange", Lager = 1, Pris = 25.0M };

            Console.WriteLine("æble 4 equals æble 1: " + æble4.Equals(æble1));

            var æble5 = new Æbler() { Navn = "Cox Orange", Lager = 1, Pris = 25.0M };

            Console.WriteLine("æble 5 equals æble 4: " + æble5.Equals(æble4));

            var æble6 = new Æbler() { Navn = "Ingrid Marie", Lager = 2, Pris = 25.0M };

            Console.WriteLine("æble 6 equals æble 5: " + æble6.Equals(æble5));

            Console.WriteLine("ReferenceEquals Metode Test:");

            //Æble 2 og 3 er er ens da da æble 3 er initieret som æble2.

            Console.WriteLine("Tester om Æble 2 og 3 er ens med reference metode:");
            Console.WriteLine(Object.ReferenceEquals(æble2, æble3));

            Console.WriteLine("Tester om Æble 4 og 5 er ens med reference metoden:");
            Console.WriteLine(Object.ReferenceEquals(æble4, æble5));

            Console.WriteLine("Tester om Æble 1 og 2 er ens med reference metoden:");
            Console.WriteLine(Object.ReferenceEquals(æble1, æble2));

            //Ovenfor er falsk da reference metoden ikke genkender værdierne som ens. Den genkender kun objekter som ens.

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
