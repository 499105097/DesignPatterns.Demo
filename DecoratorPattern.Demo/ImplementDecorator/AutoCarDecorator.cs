using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Demo
{
    /// <summary>
    /// ConcreteDecorator
    /// </summary>
    public class AutoCarDecorator : CarDecorator
    {
        public AutoCarDecorator(ICar car) : base(car)
        {
        }
        public override void Run()
        {
            _car.Run();
            AutoRun();
        }
        private void AutoRun()
        {
            Console.WriteLine("自动驾驶");
        }
    }
}
