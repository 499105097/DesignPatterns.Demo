using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Demo
{
    /// <summary>
    /// 抽象工厂基类
    /// </summary>
    public abstract class AbstractFactory
    {
        public abstract Clothes GetClothes();
        public abstract Shoes GetShoes();
        public abstract Pants GetPants();

    }
}
