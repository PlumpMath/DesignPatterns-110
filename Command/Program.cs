using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Structural;

namespace Command
{
    /*
     * 学习难度：★★★☆☆，使用频率：★★★★☆
     * 
     * （命令模式）定义：
     * 命令模式的目的是解除命令发出者和接收者之间的紧密耦合关系，使二者相对独立，有利于程序的并行开发和代码的维护。命令模式的核心思想是将请求封装为一个对象，将其作为命令发起者和接收者的中介，而抽象出来的命令对象又使得能够对一系列请求进行操作，如对请求进行排队，记录请求日志以及支持可撤销的操作等。
     * 
     * 适用情形：
     * 1.将用户界面和行为分离，使两者的开发可以并行不悖。
     * 2.在需要指定、排列和执行一系列请求的情况下，适用命令模式。
     * 3.支持修改日志。
     * 
     * 特点：
     * 1.命令模式将调用操作对象和知道如何实现该操作对象的解耦。
     * 2.在Command要增加新的处理操作对象很容易，可以通过创建新的继承自Command的子类来实现。
     * 3.命令模式可以和Memento模式结合使用，支持取消的操作。
     * 4.支持日志、请求队列和复合命令。
     */
    class Program
    {
        static void Main(string[] args)
        {
            #region 结构实现
            Receiver receiver = new Receiver();
            Structural.Command command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();

            invoker.SetCommand(command);
            invoker.ExecuteCommand();
            #endregion

            Console.WriteLine("******************************");

            #region 实践应用

            #endregion

            Console.ReadKey();
        }
    }
}
