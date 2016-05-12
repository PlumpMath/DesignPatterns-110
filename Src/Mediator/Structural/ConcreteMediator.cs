using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Structural
{
    public class ConcreteMediator : Mediator
    {
        public override void Operation()
        {
            // ...
            ((Colleague)colleagues[0]).ToString(); // 通过中介者调用同事类的方法
            // ...
        }
    }
}
