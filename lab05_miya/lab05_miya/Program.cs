using System;

namespace lab05_miya
{
    class Program : Desserts
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Mango IceCreamSocial = new Mango("Take it anywhere!", "Eat it before your freezer does.", 4)
            {
                Budget = 30
            };
            IceCreamSocial.AskForPrice();
            IceCreamSocial.SoldInStores();

            Mango YummyFlavor = new Mango("Eat on the go.", "Freezer burn is the enemy.", 40);
            YummyFlavor.TimesYouSharedIceCream();
            Console.WriteLine("Mochi is NOT for sharing. It's simply too small.");
            YummyFlavor.CoolOffWithIceCream();
            Console.Read();
        }

        public override string CoolOffWithIceCream()
        {
            //throw new NotImplementedException();
            string KeepCool = "";
            return KeepCool;
        }
    }
}

//## Directions

//- Using a problem domain from your background, create your own object class model using all 4 OOPs principles.
//- Be sure to include a drawn out diagram showing the relationship between your classes
//- Comment within your code where each OOPs principle is being used
//- Create methods in each class, No logic code is required other than `Console.WriteLine` when nececsary.

//- Clearly label each use of each OOP principle
//- Have at least:
//  - 3 abstract classes
//  - 3 lines of inheritance
//  - 3 abstract methods
//  - 3 virtual methods
//  - 3 override methods(label what they are overriding and why)
//  - Reason behind each access modifier
//  - document what & why in code within comments
  
//## ReadMe
//- Your readme should include the following information:
//	- How long did it take you to complete this assignment?
//	- What did you struggle with? Why? How did you solve?
//	- What did you learn during this assignment?
//    - What resources did you utilize for this assingment?

//## Rubric
//- 4pts: All 4 OOPs principles implemented
//- 2pts: Diagram created and labeled to show relationships
//- 1pts: Application runs without any errors
//- 1pts: Readme included with answers to questions
//- 1pts: Class structure is comprehensible
//- 1pts: Comments within the code labeling OOPs locations