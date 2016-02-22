using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Structural;

namespace Strategy
{
    /*
     * 学习难度：★☆☆☆☆，使用频率：★★★★☆
     * 
     * (策略模式)定义：
     * 策略是为达到某一目的而采取的手段或方法，策略模式的本质是目标与手段的分离，手段不同而最终达成的目标一致。客户只关心目标而不在意具体的实现方法，实现方法要根据具体的环境因素而变化。
     * 
     * 适用情形：
     * 1.如果在一个系统里面有许多类，它们之间的区别仅在于它们的行为，那么使用策略模式可以动态地让一个对象在许多行为中选择一种行为。
     * 2.一个系统需要动态地在几种算法中选择一种。这些具体算法类均有统一的接口，由于多态性原则，客户端可以选择使用任何一个具体算法类，并只持有一个数据类型是抽象算法类的对象。
     * 3.一个系统的算法使用的数据不可以让客户端知道。策略模式可以避免让客户端涉及到不必要接触到的复杂的和只与算法有关的数据。
     * 4.如果一个对象有很多的行为，如果不用恰当的模式，这些行为就只好使用多重的条件选择语句来实现。此时，使用策略模式，把这些行为转移到相应的具体策略类里面，可以避免使用难以维护的多重条件选择语句。
     * 
     * 优点：
     * 1.策略模式恰当使用继承可以把公共的代码移到父类里面，从而避免重复的代码。
     * 2.策略模式提供了可以替换继承关系的办法。继承可以处理多种算法或行为。如果不是用策略模式，那么使用算法或行为的环境类就可能会有一些子类，每一个子类提供一个不同的算法或行为。但是，这样一来算法或行为的使用者就和算法或行为本身混在一起。决定使用哪一种算法或采取哪一种行为的逻辑就和算法或行为的逻辑混合在一起，从而不可能再独立演化。继承使得动态改变算法或行为变得不可能。
     * 3.使用策略模式可以避免使用多重条件判断语句。
     * 
     * 缺点:
     * 1.客户端必须知道所有的策略类，并自行决定使用哪一个策略类。策略模式只适用于客户端知道所有的算法或行为的情况。
     * 2.策略模式造成很多的策略类。
     */
    class Program
    {
        static void Main(string[] args)
        {
            #region 结构实现
            Context context;

            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();
            #endregion

            Console.ReadKey();
        }
    }
}
