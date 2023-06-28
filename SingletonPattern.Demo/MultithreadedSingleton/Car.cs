using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern.Demo.MultithreadedSingleton
{
    /// <summary>
    /// 多线程单例
    /// </summary>
    public sealed class Car
    {
        private static Car car;
        private static object obj = new object();
        private Car() { }
        public static Car GetInstance()
        {
            if (car is null)
            {
                lock (obj)
                {
                    if (car is null)
                    {
                        car = new Car();
                    }
                }
            }
            return car;
        }
        public void Run()
        {
            Console.WriteLine("多线程单例：汽车跑起来");
        }
    }
}
