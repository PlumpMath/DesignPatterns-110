using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Structural
{
    public class ConcreteSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("Called ConcreteSubject.Request()");
        }
    }
}
