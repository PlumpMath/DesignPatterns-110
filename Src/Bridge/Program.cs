using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge.Practical;
using Bridge.Structural;

namespace Bridge
{
    /*
     * 学习难度：★★★☆☆，使用频率：★★★☆☆
     * 
     * （桥接模式）定义：
     * 当一个抽象可能有多个实现时，通常用继承来进行协调。抽象类定义对该抽象的接口，而具体的子类则用不同的方式加以实现。继承机制将抽象部分与它的实现部分固定在一起，使得难以对抽象部分和实现部分独立地进行修改、扩充和重用。
     * 如果一个抽象类或接口有多个具体实现子类，而这些子类之中有内容或概念上重叠，需要我们把抽象的共同部分各自独立开来：即原来是准备放在一个接口里，现在需要设计两个接口——抽象接口和行为接口。然后再分别针对各自的具体子类定义抽象接口和行为接口的方法和调用关系。
     * 桥接模式的用意是将抽象化(Abstraction)与实现化(Implementation)脱耦，使得二者可以独立地变化。
     * 抽象化(Abstraction)
　　      存在于多个实体中的共同的概念性联系，即为抽象化。作为一个过程，抽象化就是忽略一些信息，从而把不同的实体当做同样的实体对待。
     * 实现化(Implementation)
　　      抽象化给出的具体实现，即为实现化。
     * 脱耦
　　      耦合是指两个对象的行为的某种强关联，脱耦则是要去掉它们之间的强关联。在这里，脱耦是指将抽象化和实现化之间的耦合解脱，或者将它们之间的强关联改换成弱关联。将两者之间的继承关系改为聚合关系，就是将它们之间的强关联改换成为弱关联。
　　      桥接模式中的脱耦，是指抽象化和实现化之间使用组合/聚合关系，而不是继承关系，从而使两者可以相对独立地变化。
     * 
     * 适用情形：
     * 1.不希望在抽象与实现部分之间有固定的绑定关系；
     * 2.类的抽象以及它的实现都应该可以通过生成子类的方法加以扩充。这时桥接模式可以对不同的抽象接口和实现部分进行组合，并分别对它们进行扩充；
     * 3.对抽象的实现部分进行修改应对客户不产生影响，即客户的代码不必重新编译；
     * 4.想对客户完全隐藏抽象的实现部分；
     * 5.想在多个对象间共享实现，但同时要求客户并不知道这点。
     * 
     * 特点:
     * 1.分离接口及其实现部分，一个实现未必不变地绑定在一个接口上。抽象类的实现可以在运行时刻进行配置，一个对象甚至可以在运行时刻改变它的实现；
     * 2.将Abstraction与Implementor分离有助于降低对实现部分编译时刻的依赖性；当改变一个实现类时，并不需要重新编译Abstraction类和Client类。为了保证一个类库的不同版本之间的兼容，需要有这个特性；
     * 3.接口与实现分离有助于分层，从而产生更好的结构化系统。系统的高层部分仅需要知道Abstraction和Implementor即可；
     * 4.提高可扩充性。可以独立的对Abstraction和Implementor层次结构进行扩充；
     * 5.实现细节对Client透明。可以对Client隐藏实现细节，如共享Implementor对象以及相应的引用计数机制。
     */
    class Program
    {
        static void Main(string[] args)
        {
            #region 结构实现
            Abstraction abstraction = new RefinedAbstraction();

            abstraction.Implementor = new ConcreteImplementorA();
            abstraction.Operation();

            abstraction.Implementor = new ConcreteImplementorB();
            abstraction.Operation();
            #endregion

            Console.WriteLine("******************************");

            #region 实践应用
            MakeCoffeeSingleton whiteCoffeeSingleton = new MakeCoffeeSingleton(new WhiteCoffee());

            // 中杯牛奶咖啡
            MediumCupCoffee mediumWhiteCoffee = new MediumCupCoffee();
            mediumWhiteCoffee.Make();

            // 大杯牛奶咖啡
            LargeCupCoffee largeCupWhiteCoffee = new LargeCupCoffee();
            largeCupWhiteCoffee.Make();

            MakeCoffeeSingleton blackCoffeeSingleton = new MakeCoffeeSingleton(new BlackCoffee());
            // 中杯原味咖啡
            MediumCupCoffee mediumBlackCoffee = new MediumCupCoffee();
            mediumBlackCoffee.Make();

            // 大杯牛奶咖啡
            LargeCupCoffee largeCupBlackCoffee = new LargeCupCoffee();
            largeCupBlackCoffee.Make();
            #endregion

            Console.ReadKey();
        }
    }
}
