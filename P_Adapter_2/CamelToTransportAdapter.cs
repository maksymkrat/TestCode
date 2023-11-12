namespace P_Adapter_2
{
    public class CamelToTransportAdapter : ITransport
    {
        private Camel camel;

        public CamelToTransportAdapter(Camel camel)
        {
            this.camel = camel;
        }

        public void Drive()
        {
            camel.Move();
        }
    }
}