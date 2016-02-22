using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.Structural;

namespace Observer
{
    /*
     * 学习难度：★★★☆☆，使用频率：★★★★★
     * 
     * （观察者模式）定义：
     * 定义对象间的一种一对多的依赖关系，当一个对象的状态发生改变时，所有依赖于它的对象都得到通知并被自动更新。
     * 
     * 适用情形:
     * 1.当一个抽象模型有两个方面，其中一方面依赖于另一方面。将这二者封装在独立的对象中以使它们可以各自独立地改变和复用。
     * 2.当对一个对象的改变需要同时改变其他对象，而不需要知道具体有多少对象有待改变。
     * 3.当一个对象必须通知其他对象，而它又不需要知道其它的通知对象是谁，那些其它对象是谁不影响它发送通知这件事。
     * 
     * 特点：
     * 1.使用面向对象的抽象，Observer模式使得可以独立地改变目标与观察者，从而使二者之间的依赖关系达到松耦合。
     * 2.目标发送通知时，无需指定观察者，通知会自动传播。观察者自己决定是否需要订阅通知。
     * 3.在C#中的Event。委托充当了Observer接口，而提供事件的对象充当了目标对象，委托是比抽象Observer接口更为松耦合的设计。
     */
    class Program
    {
        static void Main(string[] args)
        {
            // Configure Observer pattern
            ConcreteSubject s = new ConcreteSubject();

            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));

            // Change subject and notify observers
            s.SubjectState = "ABC";
            s.Notify();

            Console.ReadKey();
        }
    }
}
