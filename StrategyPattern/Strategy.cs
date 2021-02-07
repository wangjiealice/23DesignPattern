using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class Algorithm
    {
        IStrategy algorithmStrategy;
        public Algorithm(IStrategy strategy)
        {
            algorithmStrategy = strategy;
        }

        public int ExecuteStrate(int num1, int num2)
        {
            return algorithmStrategy.DoOperation(num1, num2);
        }
    }
}
