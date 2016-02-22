using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Practical.IntrinsicIterator
{
    /// <summary>
    /// 定义一个具体的聚合类
    /// </summary>
    public class ConcreteAggregate : Aggregate
    {
        // 存储元素的集合
        private static object[] objs = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        /// <summary>
        /// 定义具体的迭代器类
        /// </summary>
        private class ConcreteIterator : Iterator
        {
            private int _index = 0;

            public void First()
            {
                _index = 0;
            }

            public void Next()
            {
                if (_index < objs.Length)
                {
                    _index++;
                }
            }

            public bool IsDone()
            {
                return _index == objs.Length;
            }

            public object CurrentItem()
            {
                return objs[_index];
            }
        }

        /// <summary>
        /// 获得元素个数
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return objs.Length;
        }

        /// <summary>
        /// 获取指定序号的元素
        /// </summary>
        /// <param name="index">指定的序号</param>
        /// <returns></returns>
        public object GetElement(int index)
        {
            if (index < 0 || index > objs.Length)
            {
                return null;
            }

            return objs[index];
        }

        /// <summary>
        /// 创建该聚合类的迭代器
        /// </summary>
        /// <returns></returns>
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator();
        }
    }
}
