using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_miya
{
    class MikawayaBrand : Mochi
    {
        public int NumberOfFlavors
        {
            get; set;
        }

        public override string CoolOffWithIceCream()
        {
            //throw new NotImplementedException();
            string stayCool = "It's hot outside! Grab some ice cream.";
            return stayCool;
        }

        public override bool PetsCanHaveSome()
        {
            Console.WriteLine();
            return false;
            //throw new NotImplementedException();
        }

        public virtual void SoldInStores()
        {
            Console.WriteLine("Mikawaya is sold in Uwajimaya and QFC, if you're looking for delicious mochi ice cream");
        }

    }
}
