using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Demo
{
    /// <summary>
    /// 抽象工厂类
    /// </summary>
    public abstract class AbstractFactory
    {
        public abstract Clothes GetClothes();

    }
}
