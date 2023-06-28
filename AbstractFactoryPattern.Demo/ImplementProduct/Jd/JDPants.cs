using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Demo
{
    public class JDPants : Pants
    {
        public override void Buy()
        {
            Console.WriteLine("买京东裤子！");
        }
    }
}
