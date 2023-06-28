using System;

namespace AbstractFactoryPattern.Demo
{
    /// <summary>
    /// 抽象工厂模式
    /// 定义：提供一个接口，可以创建一系列相关或相互依赖的对象，而无需指定它们具体的类。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // 淘宝工厂
            AbstractFactory tbFactory = new TaoBaoFactory();
            tbFactory.GetClothes().Buy();
            tbFactory.GetPants().Buy();
            tbFactory.GetShoes().Buy();

            // 京东工厂
            AbstractFactory jdFactory = new JDFactory();
            jdFactory.GetClothes().Buy();
            jdFactory.GetPants().Buy();
            jdFactory.GetShoes().Buy();

        }
    }
}
