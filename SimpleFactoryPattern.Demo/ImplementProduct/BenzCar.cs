using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern.Demo
{
    public class BenzCar : Car
    {
        public override void Run()
        {
            Console.WriteLine("奔驰");
        }
    }
}
