using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Demo
{
    /// <summary>
    /// 指导者
    /// </summary>
    public class Director
    {
        public void Construct(AbstractBuilder builder)
        {
            builder.BuildDisplay();
            builder.BuildHost();
            builder.BuildMouse();
        }
    }
}
