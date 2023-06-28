using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Demo
{
    /// <summary>
    /// 加法
    /// </summary>
    public class Addition : IAlgorithm
    {
        public decimal Calculate(decimal first, decimal second)
        {
            return first + second;
        }
    }
}
