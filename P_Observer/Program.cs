using System;

namespace P_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();
            Bank bank = new Bank("some bank", stock);
            Broker broker = new Broker("Bob", stock);
            
            stock.Market();
          
            broker.StopTrade();
           
            stock.Market();
 
            Console.Read();
        }
    }
}