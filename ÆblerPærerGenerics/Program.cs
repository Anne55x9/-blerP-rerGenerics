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

            var æbleBeholdning = new List<Æbler>();
            æbleBeholdning.Add(new Æbler() { Navn = "Ingrid Marie", Lager = 50, Pris = 20.0M });
            æbleBeholdning.Add(new Æbler() { Navn = "Cox Orange", Lager = 25, Pris = 10.0M });
            æbleBeholdning.Add(new Æbler() { Navn = "Gråsten", Lager = 10, Pris = 22.0M });
            æbleBeholdning.Add(new Æbler() { Navn = "Guldborg", Lager = 100, Pris = 9.0M });
            æbleBeholdning.Add(new Æbler() { Navn = "LøgÆble", Lager = 4, Pris = 5.0M });
            æbleBeholdning.Add(new Æbler() { Navn = "Guldborg", Lager = 30, Pris = 40.0M });
            æbleBeholdning.Add(new Æbler() { Navn = "Guldborg", Lager = 150, Pris = 5.0M });
            æbleBeholdning.Add(new Æbler() { Navn = "Guldborg", Lager = 60, Pris = 5.0M });

            //Console.WriteLine("Default sortering på æblerne:");

            //foreach (var item in æbleBeholdning)
            //{
            //    Console.WriteLine(item.ToString());
            //}


            ////Console.WriteLine("Efter sortering på pris.");

            ////æbleBeholdning.Sort();

            ////foreach (var item in æbleBeholdning)
            ////{
            ////    Console.WriteLine(item.ToString());
            ////}

            //Console.WriteLine("Efter sortering på lager(Descending):");

            //æbleBeholdning.Sort(Æbler.sortLagerDescending());

            //foreach (var item in æbleBeholdning)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //Console.WriteLine("Efter sortering på lager (Ascending):");

            //æbleBeholdning.Sort(Æbler.sortLagerAscending());

            //foreach (var item in æbleBeholdning)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //Console.WriteLine("Efter sortering på navn:");

            //æbleBeholdning.Sort(Æbler.sortNavn());
            //foreach (var item in æbleBeholdning)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            ////Æble predicate delegationer:

            //Console.WriteLine("Efter sortering med ascending pris, så navn, så lager:");

            //æbleBeholdning.Sort(Æbler.sortPrisNavnLager());
            //foreach (var item in æbleBeholdning)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //var æbleFind = æbleBeholdning.Find(x => x.Navn == ("Guldborg"));

            //Console.WriteLine($"Test: {æbleFind.Pris}");

            //var æbleLagerSlet = æbleBeholdning.RemoveAll(x => x.Pris > 20);

            //Console.WriteLine($"Test om slet:{æbleLagerSlet}");

          


            var pærerBeholdning = new List<Pærer>();
            pærerBeholdning.Add(new Pærer() { Navn = "Conference", Lager = 75M, Pris = 5M });
            pærerBeholdning.Add(new Pærer() { Navn = "Concorde", Lager = 33M, Pris = 12M });
            pærerBeholdning.Add(new Pærer() { Navn = "Glorød Williams", Lager = 10, Pris = 15M });
            pærerBeholdning.Add(new Pærer() { Navn = "Noveau Poiteau", Lager = 5M, Pris = 22M });
            pærerBeholdning.Add(new Pærer() { Navn = "Tongre", Lager = 7M, Pris = 21M });
            pærerBeholdning.Add(new Pærer() { Navn = "Tongre", Lager = 7M, Pris = 21M });
            pærerBeholdning.Add(new Pærer() { Navn = "Conference", Lager = 75M, Pris = 5M });
            pærerBeholdning.Add(new Pærer() { Navn = "Glorød Williams", Lager = 10, Pris = 15M });
            pærerBeholdning.Add(new Pærer() { Navn = "Glorød Williams", Lager = 20, Pris = 15M });
            pærerBeholdning.Add(new Pærer() { Navn = "Glorød Williams", Lager = 20, Pris = 20M });
            pærerBeholdning.Add(new Pærer() { Navn = "Glorød Williams", Lager = 17, Pris = 15M });
            pærerBeholdning.Add(new Pærer() { Navn = "Noveau Poiteau", Lager = 5M, Pris = 22M });
            pærerBeholdning.Add(new Pærer() { Navn = "Concorde", Lager = 33M, Pris = 12M });

            //Delegate af typen predicate med pærer:
            Console.WriteLine("1. Test med lager nummer = 10;");

            var minListe = pærerBeholdning.FindAll(x => x.Lager == 10);

            foreach (var item in minListe)
            {
                Console.WriteLine(item.Navn);
            }

            Console.WriteLine("2. Test med navn på Concorde");

            var minListe1 = pærerBeholdning.FindAll(x => x.Navn.Equals("Concorde"));

            foreach (var item in minListe1)
            {
                Console.WriteLine(item.Pris);
            }

            Console.WriteLine("3. Test med elementer i listen som koster over 15 kr");

            var PærerOver15kr = pærerBeholdning.FindAll(x => x.Pris > 15);

            foreach (var item in PærerOver15kr)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Slut på test 3.");

            Console.WriteLine("Test 4 søg på navnet Glorød Williams");

            var pærerListeNavnGW = pærerBeholdning.FindAll(x => x.Navn.Equals("Glorød Williams"));

            foreach (var item in pærerListeNavnGW)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Test 4 slut.");

            Console.WriteLine("Test 5 find første element i listen hvor lager er 20 ");

            var elementLagerlig20 = pærerBeholdning.Find(x => x.Lager == 20);

            Console.WriteLine(elementLagerlig20.Navn);

            Console.WriteLine("Slut på test 5");

            Console.WriteLine("Test 6 find første element som hedder Glorød Williams");

            var minListe2 = pærerBeholdning.Find(x => x.Navn == ("Glorød Williams"));

            Console.WriteLine(minListe2.Pris);

            Console.WriteLine("Test 6 slut");

            Console.WriteLine("Test 7 find første element hvori re indgår");

            var reInhold = pærerBeholdning.Find(x => x.Navn.Contains("re"));

            Console.WriteLine(reInhold.Navn);

            Console.WriteLine("Test 7 slut");

            Console.WriteLine("Test 8 slet elementer i listen hvor lager * pris <= 250");

            var sletListe = pærerBeholdning.RemoveAll(x => x.Lager * x.Pris <= 250);

            Console.WriteLine(sletListe);

            var sletListe2 = pærerBeholdning.FindAll(x => x.Lager * x.Pris > 250);


            foreach (var item in sletListe2)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Test 8 slut");

            //decimal værdiTotalÆbler = FrugtHandler.CalculateSumÆbler(æbleBeholdning);
            //Console.WriteLine("Så meget er æblebeholdningen værd : " + værdiTotalÆbler);

            //decimal værdiTotalPærer = FrugtHandler.CalculateSumPærer(pærerBeholdning);
            //Console.WriteLine("Så meget er pærerbeholdningen værd: " + værdiTotalPærer);


            //Console.WriteLine("Her starter Equals Metode opgaven:");

            ////Opagev 1 - Reference and equality

            ////Opgave 1.:

            //var æble1 = new Æbler() { Navn = "Cox Orange", Lager = 22, Pris = 10.0M };
            //var æble2 = new Æbler() { Navn = "Cox Orange", Lager = 22, Pris = 10.0M };

            ////Opgave 2.:

            //Console.WriteLine(æble1.Equals(æble2));
            //Console.WriteLine("æble 1 equals æble 2: " + æble1.Equals(æble2));

            ////Opgave 3.:

            //Æbler æble3 = æble2;

            ////Opgave 4.:

            //Console.WriteLine("æble 2 equals æble 3: " + æble2.Equals(æble3));

            ////opgave 8: Test på typen æbler eller null eller andet(Pærer).

            //Console.WriteLine("Tester på hvilken type jeg initierer. Er det æble er det true, andet er false");

            //var æbleType1 = new Æbler() {Navn = "Sofie", Lager = 2, Pris = 15.0M};
            //var æbleType2 = new Æbler() {Navn = "Sofie", Lager = 2, Pris = 15.0M};
            //var pæreType1 = new Pærer() {Navn = "Sofie", Lager = 2, Pris = 15.0M};
            //var æbleType3 = new Æbler() {Navn = "Sofie", Lager = 2, Pris = 15.0M};
            //æbleType3 = null;

            //Console.WriteLine("Jeg sammenlignes med et æble: " + æbleType1.Equals(æbleType2));
            //Console.WriteLine("Jeg sammenlignes med et æble: " + æbleType1.Equals(pæreType1));
            //Console.WriteLine("Jeg sammenlignes med et æble: " + æbleType1.Equals(æbleType3));

            //Console.WriteLine("Opgave 3 i Equals Metode opgaven.");
            ////Opgave 3.

            ////Opgave 1 Prøv med forskellige æble objekter og tjek de er ens eller ej med equal metoden:

            //var æble4 = new Æbler() { Navn = "Cox Orange", Lager = 1, Pris = 25.0M };

            //Console.WriteLine("æble 4 equals æble 1: " + æble4.Equals(æble1));

            //var æble5 = new Æbler() { Navn = "Cox Orange", Lager = 1, Pris = 25.0M };

            //Console.WriteLine("æble 5 equals æble 4: " + æble5.Equals(æble4));

            //var æble6 = new Æbler() { Navn = "Ingrid Marie", Lager = 2, Pris = 25.0M };

            //Console.WriteLine("æble 6 equals æble 5: " + æble6.Equals(æble5));

            //Console.WriteLine("ReferenceEquals Metode Test:");

            ////Æble 2 og 3 er er ens da da æble 3 er initieret som æble2.

            //Console.WriteLine("Tester om Æble 2 og 3 er ens med reference metode:");
            //Console.WriteLine(Object.ReferenceEquals(æble2, æble3));

            //Console.WriteLine("Tester om Æble 4 og 5 er ens med reference metoden:");
            //Console.WriteLine(Object.ReferenceEquals(æble4, æble5));

            //Console.WriteLine("Tester om Æble 1 og 2 er ens med reference metoden:");
            //Console.WriteLine(Object.ReferenceEquals(æble1, æble2));

            ////Ovenfor er falsk da reference metoden ikke genkender værdierne som ens. Den genkender kun objekter som ens.

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
