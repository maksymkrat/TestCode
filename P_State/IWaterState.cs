﻿namespace P_State
{
    public interface IWaterState
    {
        void Heat(Water water);
        void Frost(Water water);
    }
}