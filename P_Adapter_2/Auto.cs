using System;

namespace P_Adapter_2
{
    public class Auto : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("the car is driving on the road");
        }
    }
}