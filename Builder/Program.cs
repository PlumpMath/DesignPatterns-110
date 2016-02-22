using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Practical;
using Builder.Structural;

namespace Builder
{
    /*
     * 学习难度：★★★★☆，使用频率：★★☆☆☆
     * 
     * 定义：
     * 建造者模式（Builder）将复杂的构建与其表示相分离，使得同样的构建过程可以创建不同的表示。
     * 
     * 适用情形：
     * 1.需要生成的产品对象有复杂的内部结构
     * 2.需要生成的产品对象的属性相互依赖，建造者模式可以强迫生成顺序
     * 3.在对象创建过程中会使用到系统中的一些其他对象，这些对象在产品对象的创建过程中不易得到
     * 
     * 特点:
     * 1.建造者模式的使用使得产品的内部表对象可以独立地变化。使用建造者模式可以使客户不必知道产品内部组成的细节
     * 2.每一个Builder都相对独立，而与其他Builder无关
     * 3.可使对构造过程更加精细控制
     * 4.将构建代码和表示代码分开
     * 5.建造者模式的缺点在于难于应付分步骤构建算法的需求变动
     */
    class Program
    {
        static void Main(string[] args)
        {
            #region 结构实现
            // Create director and builders
            Director director = new Director();

            Structural.Builder b1 = new ConcreteBuilder1();
            Structural.Builder b2 = new ConcreteBuilder2();

            // Construct two products
            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();

            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();
            #endregion

            Console.WriteLine("******************************");

            #region 实践应用
            VehicleBuilder builder;
            Shop shop = new Shop();

            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
            #endregion

            Console.ReadKey();
        }
    }
}
