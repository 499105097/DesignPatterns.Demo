using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Demo
{
    public class AlgorithmContext
    {
        private IAlgorithm _algorithm;
        public AlgorithmContext(IAlgorithm algorithm)
        {
            _algorithm = algorithm;
        }
        public IAlgorithm Algorithm { get; set; }
        public decimal Calculate(decimal first, decimal second)
        {
            return _algorithm.Calculate(first, second);
        }
    }
}
