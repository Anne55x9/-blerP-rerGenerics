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

        //public int CompareTo(Æbler other)
        //{
        //    if (this.Pris < other.Pris)
        //        return -1;
        //    else if (this.Pris == other.Pris)
        //        return 0;
        //    else
        //        return 1;
        //}

        //private class sortLagerDescendingHelper : IComparer<Æbler>
        //{
        //    public int Compare(Æbler x, Æbler y)
        //    {
        //        if (x.Lager > y.Lager)
        //            return 1;
        //        else if (x.Lager == y.Lager)
        //            return 0;
        //        else
        //            return -1;

        //    }
        //}

        //den private klasse implementerer Icomparable<æbler> derfor kan vi godt det her.

        //public static IComparer<Æbler> sortLagerDescending()
        //{
        //    return new sortLagerDescendingHelper();
        //}

        //public override string ToString()
        //{
        //    return $"Navn {this.Navn} + Pris {this.Pris} + Lager {this.Lager}";
        //}

        //En anden måde at søge på typen æbler eller pærer eller null. Kun sandt hvis det er æbler der initieseres i consollen;



        //public override bool Equals(object obj)
        //{
        //    Æbler æble = obj as Æbler;

        //    if (this.Navn == æble.Navn && this.Pris == æble.Pris && this.Lager == æble.Lager)
        //        return true;
        //    else

        //        return false;

        //}

        public override bool Equals(object obj)
        {
            Æbler æble = obj as Æbler;

            if (!(obj is Æbler) || (obj == null))
                return false;
            else
                return true;
            
        }



        //public override bool Equals(object obj)
        //{
        //    Æbler æble = obj as Æbler;
        //    if (this.Navn == æble.Navn)
        //        return true;
        //    else
        //        return false;
        //}

        public override int GetHashCode()
        {
            return Navn.GetHashCode() ^ Pris.GetHashCode() ^ Lager.GetHashCode();
        }

      



        //public override int GetHashCode()
        //{
        //    return Navn.GetHashCode();
        //}
    }
}
