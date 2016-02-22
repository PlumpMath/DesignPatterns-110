using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator.Structural;

namespace Mediator
{
    /*
     * 学习难度：★★★☆☆，使用频率：★★☆☆☆
     * 
     * 中介者模式
     */
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator mediator = new ConcreteMediator();
            ConcreteColleague colleague = new ConcreteColleague(mediator);
            mediator.Register(colleague);

            mediator.Operation();

            Console.ReadKey();
        }
    }
}
