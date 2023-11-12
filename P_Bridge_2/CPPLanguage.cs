using System;

namespace P_Bridge_2
{
    public class CPPLanguage : Ilanguage
    {
        public void Build()
        {
            Console.WriteLine("c++ compiling code");
        }

        public void Execute()
        {
            Console.WriteLine("run exe c++");
        }
    }
}