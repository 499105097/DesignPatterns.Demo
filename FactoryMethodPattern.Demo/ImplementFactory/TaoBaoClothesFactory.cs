using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Demo
{
    public class TaoBaoClothesFactory : AbstractFactory
    {
        public override Clothes GetClothes()
        {
            return new TaoBaoClothes();
        }
    }
}
