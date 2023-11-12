using System;

namespace P_Observer
{
    public class Broker : IObserver
    {
        public string Name { get; set; }
        private IObservable stock;

        public Broker( string name, IObservable stock)
        {
            this.stock = stock;
            Name = name;
            stock.RegisterObserver(this);
        }

        public void Update(object ob)
        {
            StockInfo sInfo = (StockInfo)ob;
 
            if(sInfo.USD>30)
                Console.WriteLine("Брокер {0} продает доллары;  Курс доллара: {1}", this.Name, sInfo.USD);
            else
                Console.WriteLine("Брокер {0} покупает доллары;  Курс доллара: {1}", this.Name, sInfo.USD);
        }
        
        public void StopTrade()
        {
            stock.RemoveObserver(this);
            stock=null;
        }
    }
}