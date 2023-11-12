using System;

namespace P_Adapter_2
{
    public class Camel : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Camel is going on road");
        }
    }
}