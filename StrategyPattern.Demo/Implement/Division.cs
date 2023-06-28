using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Demo
{
    /// <summary>
    /// 除法
    /// </summary>
    public class Division : IAlgorithm
    {
        public decimal Calculate(decimal first, decimal second)
        {
            return first / second;
        }
    }
}
