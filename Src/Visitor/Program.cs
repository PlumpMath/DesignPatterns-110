using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Structural;

namespace Visitor
{
    /*
     * 学习难度：★★★★☆，使用频率：★☆☆☆☆
     * 
     * （访问者模式）定义：
     * 作用于某个对象群中各个对象的操作，可以使在不改变对象本身的情况下，定义作用于对象的新操作。
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            ObjectStructure list = new ObjectStructure();
            list.AddEmployee(new FulltimeEmployee("Mike", 2000));
            list.AddEmployee(new FulltimeEmployee("Tony", 3000));
            list.AddEmployee(new ParttimeEmployee("Nancen", 800));
            list.AddEmployee(new ParttimeEmployee("Bibo", 500));

            FinanceVisitor fVisitor = new FinanceVisitor();
            HrVisitor hVisitor = new HrVisitor();

            list.Accept(fVisitor);
            list.Accept(hVisitor);

            Console.ReadKey();
        }
    }
}
