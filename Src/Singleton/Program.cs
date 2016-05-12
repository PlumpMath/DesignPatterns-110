using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /*
     * 学习难度：★☆☆☆☆，使用频率：★★★★☆
     * 
     * （单例模式）定义：
     * 要求一个类有且仅有一个实例，并且提供了一个全局的访问点，在同一时刻只能被一个线程所访问。
     * 单件模式的特点：
     * 1>、单件类只能有一个实例。
     * 2>、单件类必须自身创建唯一实例。
     * 3>、单件类必须给所有其它对象提供唯一实例。
     * 
     * 适用情形：
     * 1.当类只能有一个实例而且客户可以从一个众所周知的访问点访问时；
     * 2.当这个唯一实例应该是通过子类化可扩展的，并且客户应该无需更改代码就能适用一个扩展的实例时。
     * 
     * 特点:
     * 1.实例控制：Singleton会阻止其他对象实例化其自己的Singleton对象的副本，从而确保所有对象都访问唯一实例；
     * 2.额外的开销：虽然很小，但如果每次对象请求引用时都要检查是否存在类的实例，将仍然需要一些开销；\
     * 3.可能的开发混淆：使用Singleton对象时，开发人员必须记住自己不能使用new关键字实例化对象。因为可能无法访问库源代码，因此应用程序开发人员可能会意外发现自己无法直接实例化此类；
     * 4.对象的生存期问题：Singleton不能解决删除单个对象的问题。在提供内存管理的语言中（如.Net Framework的语言），只有Singleton类能够导致实例被取消分配，因为它包含该对象实例的私有引用。在某些语言中（如C++），其他类可以删除对象实例，但这样会导致Singleton类中出现悬浮引用。
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            #region 结构实现
            // 创建一个实例s1
            Structural.Singleton s1 = Structural.Singleton.Instance();
            // 创建一个实例s2
            Structural.Singleton s2 = Structural.Singleton.Instance();

            if (s1 == s2)
            {
                Console.WriteLine("对象为相同实例");
            }
            #endregion

            Console.WriteLine("******************************");

            #region 实践应用
            
            #endregion

            Console.ReadKey();
        }
    }
}
