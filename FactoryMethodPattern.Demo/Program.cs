using System;

namespace FactoryMethodPattern.Demo
{
    /// <summary>
    /// 工厂方法模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // 淘宝衣服工厂
            AbstractFactory tbFactory = new TaoBaoClothesFactory();
            tbFactory.GetClothes().Buy();

            // 京东衣服工厂
            AbstractFactory jdFactory = new JDClothesFactory();
            jdFactory.GetClothes().Buy();
        }
    }
}
