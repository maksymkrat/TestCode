using System;

namespace P_Bridge_2
{
    public class CorporateProgrammer : Programmer
    {
        public CorporateProgrammer(Ilanguage language) : base(language)
        {
        }

        public override void EarnMoney()
        {
            Console.WriteLine("get salary for the month");
        }
    }
}