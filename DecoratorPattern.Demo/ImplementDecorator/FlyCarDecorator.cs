using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Demo
{
    /// <summary>
    /// ConcreteDecorator
    /// </summary>
    public class FlyCarDecorator : CarDecorator
    {
        public FlyCarDecorator(ICar car) : base(car)
        {
        }
        public override void Run()
        {
            _car.Run();
            FlyRun();
        }
        private void FlyRun()
        {
            Console.WriteLine("飞行");
        }
    }
}
