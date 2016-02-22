using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Practical;
using AbstractFactory.Structural;

namespace AbstractFactory
{
    /*
     * 学习难度：★★★★☆，使用频率：★★★★★
     * 
     * 抽象工厂（Abstract Factory）模式定义：
     * 为创建一组相关或相互依赖对象提供了一个接口，而且无需指定它们的具体类。
     * 抽象工厂可以向客户提供一个接口，是客户可以在不必指定产品具体类型的情况下，创建多个产品家族中的产品对象，
     * 它强调的“系列对象”的变化。
     * 
     * 适用情形： 
     * 1.同一个产品族的Product在一起使用时，而且它们之间是相互依赖的，不可分离
     * 2.系统需要由相互关联的多个对象来构成
     * 3.当想提供一组对象而不显示它们的实现过程，只显示它们的接口
     * 4.系统不应当依赖一些具体Product类
     * 
     * 特点：
     * 1.隔离了具体类的生成，客户不需要知道怎样生成每一个具体Product，什么时间生成的。它将客户与具体的类分离，依赖于抽象类，耦合性低。
     * 2.一个产品族中的多个对象设计成一起工作，它能保证客户端始终只使用一个产品族中的对象。这对一些需要根据当前环境来决定其行为的软件系统来说是非常实用的一种设计模式。
     * 3.有利于更换产品系列，由于客户端只依赖于抽象类，更换产品系列时，只需要更改一下具体工厂名就可以。
     * 4.难以支持新种类的产品，这是因为抽象工厂接口确定了可以被创建的产品集合，支持新种类的产品就需要扩展该工厂接口，这将引起抽象工厂类及其所有子类的改变。
     * 
     * 抽象工厂模式与工厂方法模式区别：
     * 1.工厂方法模式只有一个抽象产品类，而抽象工厂模式可以有多个抽象产品类。
     * 2.工厂方法模式针对一个产品等级结构，可以派生出多个具体产品类；抽象工厂模式针对面向多个产品等级结构，每个抽象产品类可以派生出多个具体产品类。
     */
    class Program
    {
        private static void Main(string[] args)
        {
            #region 结构实现
            // Abstract factory #1
            Structural.AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();

            // Abstract factory #2
            Structural.AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();
            #endregion

            Console.WriteLine("******************************");

            #region 实践应用
            //实惠套餐
            IKFCFactory factory = new CheapPackageFactory();
            KFCFood food = factory.CreateFood();
            KFCDrink drink = factory.CreateDrink();
            Console.WriteLine("实惠套餐：");
            food.Display();
            drink.Display();

            //豪华套餐
            factory = new LuxuryPackageFactory();
            food = factory.CreateFood();
            drink = factory.CreateDrink();
            Console.WriteLine("豪华套餐：");
            food.Display();
            drink.Display();
            #endregion

            Console.ReadKey();
        }
    }
}
