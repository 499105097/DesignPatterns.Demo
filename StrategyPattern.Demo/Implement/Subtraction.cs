using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Demo
{
    /// <summary>
    /// 减法
    /// </summary>
    public class Subtraction : IAlgorithm
    {
        public decimal Calculate(decimal first, decimal second)
        {
            return first - second;
        }
    }
}
