using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proxy.Practical;

namespace Proxy
{
    /*
     * 学习难度：★★★☆☆，使用频率：★★★★☆
     * 
     * （代理模式）定义：
     * 代理模式（Proxy）定义：代理模式为客户端程序提供一种中间层以控制对这个对象的访问。
     * 
     * 适用情形：
     * 1.远程代理为一个对象在不同的地址空间提供局部代表。
     * 2.虚代理在需要创建开销很大的对象时缓存对象信息。
     * 3.保护代理控制对原始对象的访问。保护代理用于对象应该有不同的访问权限的时候。
     * 4.智能指引取代了简单指引，它在访问对象时执行了一些附加操作。它的典型用途包括：对指向实际对象的引用计数，这样当该对象没有引用时，可以自动释放。当第一次引用一个持久对象时，将它装入内存。在访问一个实际对象前，检查是否已经锁定了它，以确保其他对象不能改变它。
     * 
     * 特点：
     * 1.代理模式在访问对象时引入一定程度的间接性，可以隐藏对象的位置。
     * 2.代理模式可以对用户隐藏一种称之为copy-on-write的优化方式。当进行一个开销很大的复制操作的时候，如果复制没有被修改，则代理延迟这一复制过程，这一可以保证只有当这个对象被修改的时候才对它进行复制。
     * 
     * 代理模式与装饰模式比较分析:
     * 装饰器模式关注于在一个对象上动态的添加方法，代理模式关注于控制对对象的访问。
     * 装饰器模式中Decorator和ConcreteComponent都实现Component，代理模式中Proxy和ConcreteSubject都实现Subject。使用这两种模式，都可以很容易地在具体对象的方法前面或者后面加上自定义的方法。
     * Proxy 可以对Client隐藏对象的具体信息，在使用代理模式时，常在Proxy中创建一个对象的实例。Proxy与ConcreteSubject之间的关系在编译时就能确定。
     * 在使用装饰模式时，常是将ConcreteComponent对象作为一个参数传给ConcreteDecorator的构造器，Decorator在运行时递归的被构造。
     */
    class Program
    {
        static void Main(string[] args)
        {
            #region 结构实现
            // Create proxy and request a service
            Structural.Proxy proxy = new Structural.Proxy();
            proxy.Request();
            #endregion

            Console.WriteLine("******************************");

            #region 实践应用
            // Create math proxy
            MathProxy proxy1 = new MathProxy();

            // Do the math
            Console.WriteLine("4 + 2 = " + proxy1.Add(4, 2));
            Console.WriteLine("4 - 2 = " + proxy1.Sub(4, 2));
            Console.WriteLine("4 * 2 = " + proxy1.Mul(4, 2));
            Console.WriteLine("4 / 2 = " + proxy1.Div(4, 2));
            #endregion

            Console.ReadKey();
        }
    }
}
