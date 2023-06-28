using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Demo
{
    public class TaoBaoShoes : Shoes
    {
        public override void Buy()
        {
            Console.WriteLine("买淘宝鞋子！");
        }
    }
}
