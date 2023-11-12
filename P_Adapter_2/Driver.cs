namespace P_Adapter_2
{
    public class Driver
    {
        public void Travel(ITransport transport)
        {
            transport.Drive();
        }
    }
}