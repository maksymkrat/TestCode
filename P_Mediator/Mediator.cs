using System.Net.Sockets;

namespace P_Mediator
{
    public abstract class Mediator
    {
        public abstract void Send(string msg, Colleague colleague);
    }
}