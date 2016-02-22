using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite.Practical;
using Composite.Structural;

namespace Composite
{
    /*
     * 组合模式(学习难度：★★★☆☆，使用频率：★★★★☆
     * 
     * （组合模式）定义：
     * 组合模式主要用来处理一类具有“容器特征”的对象——即它们在充当对象的同时，又可以作为容器包含其他多个对象。
     * 
     * 适用情形：
     * 1.希望把对象表示成部分—整体层次结构；
     * 2.希望用户忽略组合对象与单个对象的不同，用户将统一地使用组合结构中所有对象。
     * 
     * 特点：
     * 1.定义了包含基本对象和组合对象的类层次结构。基本对象可以被组合成更复杂的组合对象，而这个组合对象又可以被组合，不断的递归下去。客户代码中，任何用到基本对象的地方都可以使用组合对象；
     * 2.简化客户代码。客户可以一致地使用组合结构和单个对象。这样用户就不必关心处理的是一个叶子节点还是一个组合组件，从而简化了客户代码；
     * 3.使得新增类型的组件更加容易。新定义的Composite或Leaf子类自动地与已有的结构和客户代码一起协同工作，客户程序不需因新的Component类而改变。
     */
    class Program
    {
        private static void Main(string[] args)
        {
            #region 结构实现

            // Create a tree structure
            Structural.Composite root = new Structural.Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Structural.Composite comp = new Structural.Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);
            root.Add(new Leaf("Leaf C"));

            // Add and remove a leaf
            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            // Recursively display tree
            root.Display(1);

            #endregion

            Console.WriteLine("******************************");

            #region 实践应用
            Graphics graphics = new Graphics("全部图形");

            Circle circle = new Circle("圆形", 5);
            graphics.Add(circle);

            Rectangle rectangle = new Rectangle("矩形", 4, 5);
            graphics.Add(rectangle);

            Triangle triangle = new Triangle("三角形", 3, 4, 5);
            graphics.Add(triangle);

            graphics.Display();
            #endregion

            Console.ReadKey();
        }
    }
}
