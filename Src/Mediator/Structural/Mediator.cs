using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Structural
{
    public abstract class Mediator
    {
        protected List<Colleague> colleagues = new List<Colleague>(); // 用于存储同事对象

        public void Register(Colleague colleague)
        {
            colleagues.Add(colleague);
        }

        public abstract void Operation();
    }
}
