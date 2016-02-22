using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFactory.Practical;
using SimpleFactory.Structural;

namespace FactoryMethod
{
    /*
     * 学习难度：★★☆☆☆，使用频率：★★★☆☆
     * 
     * 简单工厂模式简介:
     * 1.简单工厂模式定义一个Factory类，可以根据参数的不同返回不同类的实例，被创建的实例通常有共同的父类。
     * 2.简单工厂模式只需要一个Factory类。
　　 * 3.简单工厂模式又称为静态工厂模式，Factory类为静态类或包含静态方法。
     *
     * 优点：
     * 1.实现了创建和使用分离；
     * 2.Client无需知道所创建的ConcreteProduct类名，只需要知道ConcreteProduct所对应的参数。
     * 
     * 缺点：
     * 1.Factory类集中了所有ConcreteProduct的创建逻辑，职责过重。一旦需要添加新的ConcreteProduct，则需要修改Factory逻辑。
     * 这样违背了OCP（开放-关闭原则）。
     * 2.由于使用了static方法，造成Factory无法形成基于继承的结构。
     */
    class Program
    {
        private static void Main(string[] args)
        {
            Product product = ProductFactory.CreateProduct();
            Console.WriteLine("Created {0}", product.GetType().Name);

            decimal money = 100m;
            var payment = PaymentFactory.CreatePayment("ABC");
            Console.WriteLine(payment.Payfor(money));

            Console.ReadKey();
        }
    }
}
