using System;

namespace SingletonPattern.Demo
{
    /// <summary>
    /// 单例模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //普通单例
            Singleton.Car car = Singleton.Car.GetInstance();
            car.Run();

            //静态单例
            StaticSingleton.Car staticCar = StaticSingleton.Car.GetInstance;
            staticCar.Run();

            //多线程单例
            MultithreadedSingleton.Car multithreadCar = MultithreadedSingleton.Car.GetInstance();
            multithreadCar.Run();
        }
    }
}
