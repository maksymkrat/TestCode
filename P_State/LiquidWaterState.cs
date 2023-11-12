using System;
using System.Threading.Channels;

namespace P_State
{
    public class LiquidWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("liquid to gas");
            water.State = new GasWaterState();
        }

        public void Frost(Water water)
        {
            Console.WriteLine("liquid to ice");
            water.State = new SolidWaterState();
        }
    }
}