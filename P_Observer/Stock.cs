using System;
using System.Collections.Generic;

namespace P_Observer
{
    public class Stock : IObservable
    {
        private StockInfo stockInfo;
        private List<IObserver> observers;

        public Stock()
        {
            observers = new List<IObserver>();
            stockInfo = new StockInfo();
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(stockInfo);
            }
        }

        public void Market()
        {
            Random rnd = new Random();
            stockInfo.USD = rnd.Next(20, 40);
            stockInfo.Euro = rnd.Next(30, 50);
            NotifyObservers();
        }
    }
}