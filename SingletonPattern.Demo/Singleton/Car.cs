using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern.Demo.Singleton
{
    /// <summary>
    /// 普通单例
    /// </summary>
    public sealed class Car
    {
        private static Car car;
        private Car() { }
        public static Car GetInstance()
        {
            if (car is null)
            {
                car = new Car();
            }
            return car;
        }
        public void Run()
        {
            Console.WriteLine("普通单例：汽车跑起来");
        }
    }
}
