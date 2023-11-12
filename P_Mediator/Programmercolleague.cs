using System;

namespace P_Mediator
{
    public class Programmercolleague : Colleague
    {
        public Programmercolleague(Mediator mediator) : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine("Сообщение программисту: " + message);
        }
    }
}