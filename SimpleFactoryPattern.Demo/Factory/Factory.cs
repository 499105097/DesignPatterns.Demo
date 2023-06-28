using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern.Demo
{
    public class Factory
    {
        public static Car GetInstance(string typeStr)
        {
            Car car;
            switch (typeStr)
            {
                case "Benz":
                    car = new BenzCar();
                    break;
                case "Bmw":
                    car = new BmwCar();
                    break;
                default:
                    throw new AggregateException("未知类型");
            }
            return car;
        }
    }
}
