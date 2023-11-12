using System;

namespace P_Bridge_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // создаем нового программиста, он работает с с++
            Programmer freelancer = new FreeLanceProgrammer(new CPPLanguage());
            freelancer.DoWork();
            freelancer.EarnMoney();
            // пришел новый заказ, но теперь нужен c#
            freelancer.Language = new CSharpLanguage();
            freelancer.DoWork();
            freelancer.EarnMoney();
 
            Console.Read();
        }
    }
}