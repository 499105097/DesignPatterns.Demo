using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Demo
{
    /// <summary>
    /// 联想电脑建造者
    /// </summary>
    public class ThinkPadBuilder : AbstractBuilder
    {
        Computer computer = new Computer();
        public override void BuildDisplay()
        {
            computer.AddPart("显示器");
        }

        public override void BuildHost()
        {
            computer.AddPart("主机");
        }

        public override void BuildMouse()
        {
            computer.AddPart("鼠标");
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }
}
