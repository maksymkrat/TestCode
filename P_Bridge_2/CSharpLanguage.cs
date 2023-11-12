using System;

namespace P_Bridge_2
{
    public class CSharpLanguage : Ilanguage
    {
        public void Build()
        {
            Console.WriteLine("c# build code");
        }

        public void Execute()
        {
            Console.WriteLine("run exe c#");
        }
    }
}