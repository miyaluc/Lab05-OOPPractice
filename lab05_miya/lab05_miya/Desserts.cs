using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_miya
{
    abstract class Desserts
    {
        public string NameOfStores
        {
            get; set;
        }
        public int Budget
        {
            get; set;
        }
        protected int AddToDesserts()
        {
            int desserts = 0;
            return desserts;
        }
        public virtual int AskForPrice()
        {
            Console.WriteLine("The price is $5.");
            return 5;
        }
        public abstract string CoolOffWithIceCream();
    }
}
