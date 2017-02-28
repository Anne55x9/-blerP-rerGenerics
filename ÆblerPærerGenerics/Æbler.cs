using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ÆblerPærerGenerics
{
    // fodre interface da den er generisk. Generic<T> Lists. 
    public class Æbler 
        //:IComparable<Æbler>
    {
        public string Navn { get; set; }
        public decimal Pris { get; set; }
        public int Lager { get; set; }


        private class sortLagerDescendingHelper : IComparer<Æbler>
        {
            public int Compare(Æbler x, Æbler y)
            {
                if (x.Lager > y.Lager)
                    return 1;
                else if (x.Lager == y.Lager)
                    return 0;
                else
                    return -1;
            }
        }

        private class sortLagerAscendingHelper : IComparer<Æbler>
        {
            public int Compare(Æbler x, Æbler y)
            {
                if (x.Lager < y.Lager)
                    return 1;
                else if (x.Lager == y.Lager)
                    return 0;
                else
                    return -1;
            }
        }

        private class sortNavnAlfabeticalgHelper: IComparer<Æbler>
        {
            public int Compare(Æbler x, Æbler y)
            {
                int a = String.Compare(x.Navn, y.Navn);
                return a;
            }
        }

        private class sortbyPrisNavnLagerAscendingHelper: IComparer<Æbler>
        {
            public int Compare(Æbler x, Æbler y)
            {
                
                if (x.Pris > y.Pris)
                {
                    return -1;
                }
                else if (x.Pris == y.Pris)
                {
                    int a = String.Compare(x.Navn, y.Navn);
                        if (a == 0)
                        {
                            return y.Lager - x.Lager;
                        }

                    return a;
                }
                else
                    return 1;
            }

        }


        /// <summary>
        /// I CompareTo metoden afhænger rækkefølgen i listen af hvorledes krodillenæbbet vender. 
        /// I de nedefor stående eksempler er de de laveste værdier først i listerne, 
        /// men vendes krodillen næbet vil de højeste værdier komme først i sorteringen.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>

        ////Override af CompareTo metoden som sorterer efter æblernes pris med laveste pris først.

        //public int CompareTo(Æbler other)
        //{
        //    if (this.Pris < other.Pris)
        //        return -1;
        //    else if (this.Pris == other.Pris)
        //        return 0;
        //    else
        //        return 1;
        //}

        ////Override af CompareTo metoden som sorterer efter lager antal med laveste beholdning først. 

        //public int CompareTo(Æbler other)
        //{
        //    if (this.Lager < other.Lager)
        //        return -1;
        //    else if (this.Lager == other.Lager)
        //        return 0;
        //    else
        //        return 1;
        //}

        ////Override af CompareTo metoden som sorterer efter Navn. 

        //public int CompareTo(Æbler other)
        //{
        //    int a = String.Compare(this.Navn, other.Navn);
        //    return a;
        //}

        ////Override af CompareTo metoden som sorterer først på navn, dernæst pris og endeligt lager beholdning. 

        //public int CompareTo(Æbler other)
        //{
        //    int a = String.Compare(this.Navn, other.Navn);

        //    if (a == 0)
        //    {
        //        int prisSammenligning = Decimal.Compare(this.Pris, other.Pris);
        //        if (prisSammenligning == 0)
        //        {
        //            return this.Lager - other.Lager;

        //        }
        //        return prisSammenligning;
        //    }

        //    return a;

        //}

        ////Override af CompareTo metoden som sorterer først på lager beholdning, dernæst navn og pris. 

        //public int CompareTo(Æbler other)
        //{
        //    int a = String.Compare(this.Navn, other.Navn);

        //    if (this.Lager < other.Lager)
        //        return -1;
        //    else if (this.Lager == other.Lager)
        //    {
        //        int prisSammeligning = Decimal.Compare(this.Pris, other.Pris);
        //        if (a == 0)
        //        {
        //            return prisSammeligning;
        //        }

        //        return a;
        //    }
        //    else
        //        return 1;

        //}

        //Privat klasse som implementerer Icomparer interfacet af typen æbler. Interfacet implementerer metoden Compare.


        //Static metode som returnere en ny instans fra sortLagerDescendingHelper klasssen.  
        //Den private klasse implementerer Icomparable<æbler> derfor kan vi godt det her.

        public static IComparer<Æbler> sortLagerDescending()
        {
            return (IComparer<Æbler>) new sortLagerDescendingHelper();
        }

        public static IComparer<Æbler> sortLagerAscending()
        {
            return (IComparer<Æbler>)new sortLagerAscendingHelper();
        }

        public static IComparer<Æbler> sortNavn()
        {
            return (IComparer < Æbler >) new sortNavnAlfabeticalgHelper();
        }

        public static IComparer<Æbler> sortPrisNavnLager()
        {
            return (IComparer<Æbler>)new sortbyPrisNavnLagerAscendingHelper();
        }

        //// Override af Equals metoden som med if statement som tester på typen der smmelignes med. Hvis æble true, hvis null eller andet er det false.

        //public override bool Equals(object obj)
        //{
        //    Æbler æble = obj as Æbler;

        //    if (!(obj is Æbler) || (obj == null))
        //        return false;
        //    else
        //        return true;

        //}

        ////Override af Equals metoden som med if statement sammenligner på æbles navn, pris og lager antal.

        //public override bool Equals(object obj)
        //{
        //    Æbler æble = obj as Æbler;

        //    if (this.Navn == æble.Navn && this.Pris == æble.Pris && this.Lager == æble.Lager)
        //        return true;
        //    else

        //        return false;

        //}


        //// Override af Equals metoden som med if statement sammenligner på æbles navn. 

        //public override bool Equals(object obj)
        //{
        //    Æbler æble = obj as Æbler;
        //    if (this.Navn == æble.Navn)
        //        return true;
        //    else
        //        return false;
        //}

        //// Override af GetHashCode metoden som retunere det sammenlignede i samme datatype.

        //public override int GetHashCode()
        //{
        //    return Navn.GetHashCode() ^ Pris.GetHashCode() ^ Lager.GetHashCode();
        //}

        ////Tostring metoden som viser output af cw med tekst i console vinduet:

        public override string ToString()
        {
            return $"Navn {this.Navn} + Pris {this.Pris} + Lager {this.Lager}";
        }

       
    }
}

