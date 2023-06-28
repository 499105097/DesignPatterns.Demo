using System;

namespace StrategyPattern.Demo
{
    /// <summary>
    /// 策略模式
    /// 定义：将算法与对象解耦；把一些列算法进行抽象，然后封装起来。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            decimal first = 10M;
            decimal second = 5M;
            //加
            AlgorithmContext context = new AlgorithmContext(new Addition());
            Console.WriteLine($"10 + 5= {context.Calculate(first, second)}");
            
            //减
            context.Algorithm = new Subtraction();
            Console.WriteLine($"10 - 5= {context.Calculate(first, second)}");

            //乘
            context.Algorithm = new Multiplication();
            Console.WriteLine($"10 × 5= {context.Calculate(first, second)}");

            //除
            context.Algorithm = new Division();
            Console.WriteLine($"10 ÷ 5= {context.Calculate(first, second)}");
        }
    }
}
