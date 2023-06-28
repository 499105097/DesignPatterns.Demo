using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern.Demo
{
    public class BmwCar : Car
    {
        public override void Run()
        {
            Console.WriteLine("宝马");
        }
    }
}
