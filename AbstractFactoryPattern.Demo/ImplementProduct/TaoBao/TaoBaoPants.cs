using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Demo
{
    public class TaoBaoPants : Pants
    {
        public override void Buy()
        {
            Console.WriteLine("买淘宝裤子！");
        }
    }
}
