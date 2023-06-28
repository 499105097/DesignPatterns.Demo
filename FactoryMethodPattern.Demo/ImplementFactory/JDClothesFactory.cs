using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Demo
{
    public class JDClothesFactory : AbstractFactory
    {
        public override Clothes GetClothes()
        {
            return new JDClothes();
        }
    }
}
