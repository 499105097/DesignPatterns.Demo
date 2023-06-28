using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Demo
{
    /// <summary>
    /// ConcreteComponent
    /// </summary>
    public class BenzCar : ICar
    {
        public void Run()
        {
            Console.WriteLine("奔驰开跑");
        }
    }
}
