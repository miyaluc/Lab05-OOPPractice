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
            string KeepCool = "";
            return KeepCool;
        }

        public virtual void SoldInStores()
        {
            Console.WriteLine("Mikawaya is sold in Uwajimaya and QFC, if you're looking for delicious mochi ice cream");
        }

    }
}
