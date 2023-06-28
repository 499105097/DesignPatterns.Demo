using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Demo
{
    public class TaoBaoFactory : AbstractFactory
    {
        public override Clothes GetClothes()
        {
            return new TaoBaoClothes();
        }

        public override Pants GetPants()
        {
            return new TaoBaoPants();
        }

        public override Shoes GetShoes()
        {
            return new TaoBaoShoes();
        }
    }
}
