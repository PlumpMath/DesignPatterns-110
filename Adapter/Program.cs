using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Structural.ClassAdapter;
using Adapter.Structural.ObjectAdapter;
using Adapter.Practical.ClassAdapter;
using Adapter.Practical.ObjectAdapter;

namespace Adapter
{
    /*
     * 学习难度：★★☆☆☆，使用频率：★★★★☆
     * 
     * (适配器模式)定义：
     * 1.适配器模式是通过一个类的接口转换成客户希望的另外一个接口，使原本由于接口不兼容而不能一起工作的那些类可以一起工作。
     * 2.适配器从结构上可以分为类适配器和对象适配器。其中类适配器使用继承关系来对类进行适配，而对象适配器是使用对象引用的方法来进行适配的。
     * 3.C#实现类适配器时，Target只能是接口。实现对象适配器时，Target可以是抽象类也可以是接口。
     * 
     * 适用情形：
     * 1.当适用一个已存在的类，而它的接口不符合所要求的情况；
     * 2.想要创建一个可以复用的类，该类可以与原接口的类协调工作；
     * 3.在对象适配中，当要匹配数个子类的时候，对象适配器可以适配它们的父类接口。
     * 
     * 特点：
     * 类适配器
     * 1.使得Adapter可以重定义Adaptee的部分行为。因为Adapter是Adaptee的一个子类；
     * 2.仅仅引入了一个对象，并不需要额外的指针间接得到Adaptee。
     * 对象适配器
     * 1.允许一个Adapter与多个Adaptee同时工作。Adapter也可以一次给所有的Adaptee添加功能；
     * 2.使得重定义Adaptee的行为比较困难。需要生成一个Adaptee的子类，然后使Adapter引入这个子类而不是引用Adaptee本身。
     */
    class Program
    {
        static void Main(string[] args)
        {
            #region 结构实现
            Structural.ClassAdapter.ITarget t = new Structural.ClassAdapter.Adapter();
            t.Request();
            Structural.ObjectAdapter.ITarget t1 = new Structural.ObjectAdapter.Adapter();
            t1.Request();
            #endregion

            Console.WriteLine("******************************");

            #region 实践应用
            Practical.ClassAdapter.ITarget t2 = new Practical.ClassAdapter.Adapter();
            t2.GetPower();

            Practical.ObjectAdapter.ITarget t3 = new Practical.ObjectAdapter.Adapter(new Practical.ObjectAdapter.Power());
            t3.GetPower();
            #endregion

            Console.ReadKey();
        }
    }
}
