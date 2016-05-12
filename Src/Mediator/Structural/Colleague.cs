using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Structural
{
    public abstract class Colleague
    {
        protected Mediator mediator; // 维持一个抽象中介者的引用

        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public abstract void Method1(); // 声明自身方法，处理自己的行为，共中介者调用

        // 定义依赖方法，与中介者进行通信
        public void Method2()
        {
            mediator.Operation();
        }
    }
}
