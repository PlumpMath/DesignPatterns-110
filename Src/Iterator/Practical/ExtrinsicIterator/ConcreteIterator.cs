using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Practical.ExtrinsicIterator
{
    /// <summary>
    /// 定义具体的迭代器类
    /// </summary>
    public class ConcreteIterator : Iterator
    {
        private ConcreteAggregate aggregate;
        private int index = 0;
        private int size = 0;

        /// <summary>
        /// 根据不同的聚合类进行初始化
        /// </summary>
        /// <param name="aggregate"></param>
        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
            size = aggregate.Size();
            index = 0;
        }

        public void First()
        {
            index = 0;
        }

        public void Next()
        {
            if (index < size)
            {
                index++;
            }
        }

        /// <summary>
        /// 判断是否遍历完毕
        /// </summary>
        /// <returns></returns>
        public bool IsDone()
        {
            return index >= size;
        }

        /// <summary>
        /// 获取当前遍历的元素
        /// </summary>
        /// <returns></returns>
        public object CurrentItem()
        {
            return aggregate.GetElement(index);
        }
    }
}
