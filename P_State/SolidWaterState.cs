using System;

namespace P_State
{
    public class SolidWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("ice to liquid");
            water.State = new LiquidWaterState();
        }

        public void Frost(Water water)
        {
            Console.WriteLine("continue frozen");
        }
    }
}