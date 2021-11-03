using System;
using System.Collections.Generic;
using System.Text;
using MathNet.Numerics.Random;

namespace Algorithms
{
    public static class MyRandom
    {
        public static int Next(int minValue,int  maxValue)
        {
            Random random = new Random();
            return random.Next(minValue,maxValue);
        }

        public static int MersenneTwisterNextFunction(int minValue,int maxValue)
        {
            MersenneTwister mt = new MersenneTwister();
            return mt.Next(minValue, maxValue);
        }
    }
}
