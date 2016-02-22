using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flyweight.Structural;

namespace Flyweight
{
    /*
     * 学习难度：★★★★☆，使用频率：★☆☆☆☆
     * 
     * （享元模式）定义：
     * 享元模式（Flyweight）的存在是为了避免大量拥有相同内容的小类的开销（如内存开销），使大家共享一个类。
     * 
     * 适用情形：
     * 1.一个应用程序使用了大量的对象
     * 2.完全由于使用大量的对象，造成很大的存储开销
     * 3.对象的大多数状态都可变为外部状态
     * 4.如果删除对象的外部状态，那么可以用相对较少的共享对象取代很多组对象
     * 5.应用程序不依赖对象标识
     * 
     * 特点：
     * 1.享元模式的核心是把大量共享的对象收集在一起使用简单工厂模式进行管理，避免由于大量的小对象导致系统内存过度消耗。
     * 2.享元当重复对象较多时有很好的空间复杂度，但在查找搜索上消耗了时间复杂度。
     */
    class Program
    {
        static void Main(string[] args)
        {
            #region 结构实现
            // Arbitrary extrinsic state
            int extrinsicstate = 22;
            FlyweightFactory factory = new FlyweightFactory();

            // Work with different flyweight instances
            Structural.Flyweight fx = factory.GetFlyweight("X");
            fx.Operation(--extrinsicstate);

            Structural.Flyweight fy = factory.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);

            Structural.Flyweight fz = factory.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);

            UnsharedConcreteFlyweight fu = new UnsharedConcreteFlyweight();
            fu.Operation(--extrinsicstate);
            #endregion

            Console.WriteLine("******************************");

            #region 实践应用
            #endregion

            Console.ReadKey();
        }
    }
}
