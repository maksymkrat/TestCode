﻿using System;

namespace P_Adapter_2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Driver driver = new Driver();
           
            Auto auto = new Auto();
            driver.Travel(auto);
            
            Camel camel = new Camel();
            
            ITransport camelTransport = new CamelToTransportAdapter(camel);
            driver.Travel(camelTransport);
 
            Console.Read();
        }
    }
}