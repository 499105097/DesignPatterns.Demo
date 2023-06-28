using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Demo
{
    public class TaoBaoClothes : Clothes
    {
        public override void Buy()
        {
            Console.WriteLine("买淘宝衣服！");
        }
    }
}
