using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Demo
{
    /// <summary>
    /// 电脑
    /// </summary>
    public class Computer
    {
        private List<string> parts = new List<string>();

        /// <summary>
        /// 添加部件
        /// </summary>
        /// <param name="part"></param>
        public void AddPart(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("电脑开始在组装.......");
            foreach (string part in parts)
            {
                Console.WriteLine("组件" + part + "已装好");
            }
            Console.WriteLine("电脑组装好了");
        }
    }
}
