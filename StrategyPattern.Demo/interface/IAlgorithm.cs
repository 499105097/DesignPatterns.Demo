using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Demo
{
    /// <summary>
    /// 算法
    /// </summary>
    public interface IAlgorithm
    {
        decimal Calculate(decimal first,decimal second);
    }
}
