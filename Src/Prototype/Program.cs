using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype.Practical;
using Prototype.Structural;

namespace Prototype
{
    /*
     * 学习难度：★★★☆☆，使用频率：★★★☆☆
     * 
     * 原型模式定义：
     * 原型模式（Prototype）用原型实例指定创建对象的种类，并且通过复制这些原型创建新的对象。
     * 
     * 使用情形：
     * 1.当一个系统应该独立于它的产品创建、构成和表示时；
     * 2.当要实例化的类是在运行时刻指定时，例如通过动态装载来创建一个类；
     * 3.为了避免创建一个与产品类层次平行的工厂类层次时；
     * 4.当一个类的实例只能有几个不同状态组合中的一种时。建立相应数目的原型并Clone它们可能比每次用合适的状态手工实例化该类更方便一些。
     * 
     * 特点:
     * 1.对客户隐藏了具体的产品类，因此减少了客户知道的名字的数目；
     * 2.允许客户只通过注册原型实例就可以将一个具体产品类并入到系统中，客户可以在运行时刻建立和删除原型；
     * 3.减少了子类的构造。原型模式是Clone一个原型而不是请求工厂方法创建一个，所以它不需要一个与具体产品类平行的Creator类层次；
     * 4.原型模式具有给一个应用软件动态加载新功能的能力。由于Prototype的独立性较高，可以很容易动态加载新功能而不影响旧系统；
     * 5.产品类不需要非得有任何事先确定的等级结构，因为原型模式适用于任何的等级结构；
     * 6.原型模式的最重要缺点就是每一个类必须配备一个Clone方法，而且这个Clone方法需要对类的功能进行通盘考虑。这对全新的类来说不是很难，但对已有的类进行改造时，不一定是容易的事。
     */
    class Program
    {
        static void Main(string[] args)
        {
            #region 结构实现
            // Create two instances and clone each
            ConcretePrototype1 p1 = new ConcretePrototype1("I");
            ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
            Console.WriteLine("Cloned: {0}", c1.Id);

            ConcretePrototype2 p2 = new ConcretePrototype2("II");
            ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
            Console.WriteLine("Cloned: {0}", c2.Id);
            #endregion

            Console.WriteLine("******************************");

            #region 实践应用
            ColorManager colormanager = new ColorManager();

            // Initialize with standard colors
            colormanager["red"] = new Color(255, 0, 0);
            colormanager["green"] = new Color(0, 255, 0);
            colormanager["blue"] = new Color(0, 0, 255);

            // User adds personalized colors
            colormanager["angry"] = new Color(255, 54, 0);
            colormanager["peace"] = new Color(128, 211, 128);
            colormanager["flame"] = new Color(211, 34, 20);

            // User clones selected colors
            Color color1 = colormanager["red"].Clone() as Color;
            Color color2 = colormanager["peace"].Clone() as Color;
            Color color3 = colormanager["flame"].Clone() as Color;
            #endregion

            Console.ReadKey();
        }
    }
}
