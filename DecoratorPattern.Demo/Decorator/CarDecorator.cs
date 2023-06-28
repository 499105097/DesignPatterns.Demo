using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Demo
{
    /// <summary>
    /// Decorator
    /// </summary>
    public class CarDecorator : ICar
    {
        protected ICar _car;
        public CarDecorator(ICar car)
        {
            _car = car;
        }

        public virtual void Run()
        {
            _car.Run();
        }
    }
}
