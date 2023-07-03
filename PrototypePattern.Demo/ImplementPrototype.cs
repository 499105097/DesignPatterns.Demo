using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Demo
{
    /// <summary>
    /// 实现原型
    /// </summary>
    public class ImplementPrototype : ICloneable
    {
        public void Method1()
        {
            Console.WriteLine("Method1");
        }

        public void Method2()
        {
            Console.WriteLine("Method2");
        }
        /// <summary>
        /// 深拷贝
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return JsonConvert.DeserializeObject<ImplementPrototype>(JsonConvert.SerializeObject(this));
        }
    }
}
