using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_miya
{
    class Mango : MikawayaBrand
    {
        public string Portable
        {
            get; set;
        }
        public string FreezerBurn
        {
            get; set;
        }
        public int HowManyYouCanEat
        {
            get; set;
        }
        public Mango(string VeryPortable, string FreezeBurned, int NumberEaten)
        {
            Portable = VeryPortable;
            FreezerBurn = FreezeBurned;
            HowManyYouCanEat = NumberEaten;
        }
        //add three override methods
    }
}
