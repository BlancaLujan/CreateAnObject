using System;

namespace CreateAnObject
{
    class Program
    {
        static void Main(string[] args)
        {
            PastryBox aNewClass = new PastryBox();

            aNewClass.myBrand = "Pillsbury";
            aNewClass.myItems = 100;
            aNewClass.myChocolateChipCookies = 40;
            aNewClass.myBrownies = 20;
            aNewClass.myOatmealCookies = 40;

            Console.WriteLine(aNewClass.myBrand);
            Console.WriteLine(aNewClass.myItems);
            Console.WriteLine(aNewClass.myChocolateChipCookies);
            Console.WriteLine(aNewClass.myBrownies);
            Console.WriteLine(aNewClass.myOatmealCookies);

        }
    }
}
