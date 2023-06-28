using System;

namespace DecoratorPattern.Demo
{
    class Program
    {
        /// <summary>
        /// 装饰器模式
        /// 定义：动态地给一个对象添加额外的职责，就添加功能来说，装饰模式比生成子类更加灵活
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ICar benzCar = new BenzCar();
            CarDecorator autodecorator = new AutoCarDecorator(benzCar);
            CarDecorator flydecorator = new FlyCarDecorator(autodecorator);
            //奔驰汽车
            benzCar.Run();
            //装饰自动驾驶的奔驰汽车
            autodecorator.Run();
            //装饰自动驾驶+飞行的奔驰汽车
            flydecorator.Run();
        }
    }
}
