using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Structural;

namespace Iterator
{
    /*
     * 学习难度：★★★☆☆，使用频率：★★★★★
     * 
     * （迭代器模式）定义：
     * 迭代器模式提供一种方法可以顺序访问聚合对象中各个元素，但又不暴露该对象的内部表示。
     * 
     * 适用情形:
     * 1.访问一个具体对象的内容而不暴露它的内部表示；
     * 2.支持对聚合对象的多种遍历；
     * 3.为遍历不同的聚合结构提供一个统一的接口（即支持多态迭代）。
     * 
     * 特点：
     * 1.简化聚集的行为，迭代器具备了遍历的接口，这样聚集的接口就不必具备遍历接口；
     * 2.每一个聚集对象都可以有一个或者更多的迭代器对象，每一个迭代器的迭代状态可以彼此独立（外禀迭代器）；
     * 3.遍历算法被封装到迭代器对象中，迭代算法可以独立于聚集对象变化。Client不必知道聚集对象的类型，通过迭代器可以就读取和遍历聚集对象。这样的好处是聚集本身内部数据发生变化而不影响Client的程序。
     */
    class Program
    {
        static void Main(string[] args)
        {
            #region 结构实现
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";

            ConcreteIterator i = a.CreateIterator() as ConcreteIterator;

            Console.WriteLine("Iterating over collection:");
            object item = i.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }
            #endregion

            Console.WriteLine("******************************");

            #region 实践应用
            Practical.ExtrinsicIterator.Iterator _iterator;
            Practical.ExtrinsicIterator.Aggregate _aggregate = new Practical.ExtrinsicIterator.ConcreteAggregate();
            // 获得迭代器
            _iterator = _aggregate.CreateIterator();
            while (!_iterator.IsDone())
            {
                Console.WriteLine(_iterator.CurrentItem());
                _iterator.Next();
            }


            Practical.IntrinsicIterator.Iterator _iterator1;
            Practical.IntrinsicIterator.Aggregate _aggregate1 = new Practical.IntrinsicIterator.ConcreteAggregate();
            // 获得迭代器
            _iterator1 = _aggregate1.CreateIterator();
            while (!_iterator1.IsDone())
            {
                Console.WriteLine(_iterator1.CurrentItem());
                _iterator1.Next();
            }

            #endregion

            Console.ReadKey();
        }
    }
}
