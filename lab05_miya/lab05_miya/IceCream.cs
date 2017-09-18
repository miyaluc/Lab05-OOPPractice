using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_miya
{
    abstract class IceCream : Desserts
    {
        //eat it
        //toss it
        //share it
        public bool PetsCanHaveSome()
        {
            return false;
        }
        public void EatTheStuff()
        {
            Console.WriteLine("You just bought the most enticingly arranged ice cream. What are you waiting for? Eat the stuff!");
        }
        public void TossTheStuff()
        {
            Console.WriteLine("Before you consider tossing your ice cream, why not give it to a friend or stranger?");
        }
        public int TimesYouSharedIceCream()
        {
            return 0;
        }
    }
}
