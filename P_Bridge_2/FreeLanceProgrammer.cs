using System;

namespace P_Bridge_2
{
    public class FreeLanceProgrammer : Programmer
    {
        public FreeLanceProgrammer(Ilanguage language) : base(language)
        {
        }

        public override void EarnMoney()
        {
            Console.WriteLine("get salary for tasks");
        }
    }
}