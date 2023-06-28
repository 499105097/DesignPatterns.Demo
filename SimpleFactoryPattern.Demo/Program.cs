using System;

namespace SimpleFactoryPattern.Demo
{
    /// <summary>
    /// 简单工厂模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // 奔驰
            Car benzCar = Factory.GetInstance("Benz");
            benzCar.Run();

            // 宝马
            Car bmwCar = Factory.GetInstance("Bmw");
            bmwCar.Run();
        }
    }
}
