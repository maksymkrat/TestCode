using System;

namespace P_State
{
    public class GasWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Increase the temperature of water vapor");
        }

        public void Frost(Water water)
        {
            Console.WriteLine("gas to liquid");
            water.State = new LiquidWaterState();
        }
    }
}