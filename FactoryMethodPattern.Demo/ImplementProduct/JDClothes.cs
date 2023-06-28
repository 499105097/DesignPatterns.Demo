using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Demo
{
    public class JDClothes : Clothes
    {
        public override void Buy()
        {
            Console.WriteLine("买京东衣服！");
        }
    }
}
