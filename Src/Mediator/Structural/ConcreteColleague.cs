using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Structural
{
    public class ConcreteColleague : Colleague
    {
        public ConcreteColleague(Mediator mediator)
            : base(mediator)
        { }

        public override void Method1()
        {
            // ...
        }
    }
}
