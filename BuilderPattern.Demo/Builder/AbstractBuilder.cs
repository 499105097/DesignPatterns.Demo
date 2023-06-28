using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Demo
{
    public abstract class AbstractBuilder
    {
        /// <summary>
        /// 创建显示器
        /// </summary>
        public abstract void BuildDisplay();

        /// <summary>
        /// 创建主机
        /// </summary>
        public abstract void BuildHost();
        
        /// <summary>
        /// 创建鼠标
        /// </summary>
        public abstract void BuildMouse();

        /// <summary>
        /// 获取组装好的电脑
        /// </summary>
        /// <returns></returns>
        public abstract Computer GetComputer();

    }
}
