using System;

namespace BuilderPattern.Demo
{
    /// <summary>
    /// 建造者模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            var builder = new ThinkPadBuilder();
            director.Construct(builder);
            Computer computer = builder.GetComputer();
            computer.Show();
        }
    }
}
