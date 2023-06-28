using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Demo
{
    public class JDShoes : Shoes
    {
        public override void Buy()
        {
            Console.WriteLine("买京东鞋子！");
        }
    }
}
