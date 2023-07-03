using System;

namespace PrototypePattern.Demo
{
    /// <summary>
    /// 原型模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ImplementPrototype prototype = new ImplementPrototype();
            ImplementPrototype prototypeClone = (ImplementPrototype)prototype.Clone();
        }
    }
}
