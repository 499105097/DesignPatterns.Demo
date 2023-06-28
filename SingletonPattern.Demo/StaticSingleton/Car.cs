using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern.Demo.StaticSingleton
{
    /// <summary>
    /// 静态单例
    /// </summary>
    public sealed class Car
    {
        private static readonly Car car = new Car();
        private Car() { }
        public static Car GetInstance
        {
            get
            {
                return car;
            }
        }
        public void Run()
        {
            Console.WriteLine("静态单例：汽车跑起来");
        }
    }
}
