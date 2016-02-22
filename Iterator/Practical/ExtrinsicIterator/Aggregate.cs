using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Practical.ExtrinsicIterator
{
    /// <summary>
    /// 定义一个抽象的聚合类
    /// </summary>
    public abstract class Aggregate
    {
        /// <summary>
        /// 只有一个功能，创建迭代器
        /// </summary>
        /// <returns></returns>
        public virtual Iterator CreateIterator()
        {
            return null;
        }
    }
}
