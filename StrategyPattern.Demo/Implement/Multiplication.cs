using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Demo
{
    /// <summary>
    /// 乘法
    /// </summary>
    public class Multiplication : IAlgorithm
    {
        public decimal Calculate(decimal first, decimal second)
        {
            return first * second;
        }
    }
}
