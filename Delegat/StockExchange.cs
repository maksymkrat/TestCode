using System;
using System.Threading;
using System.Threading.Tasks;

namespace Delegat
{
    public class StockExchange
    {
        public delegate void PriceChange(int prace);
        public PriceChange PriceChangeHandler { get; set; }

        public void Start()
        {
            while (true)
            {
                int bankPrice = (new Random()).Next(100);
                PriceChangeHandler(bankPrice);
                Thread.Sleep(2000);
            }
        }
    }
}