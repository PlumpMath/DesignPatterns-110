using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Structural
{
    public class Proxy : Subject
    {
        private ConcreteSubject _concreteSubject;

        public override void Request()
        {
            // Use 'lazy initialization'
            if (_concreteSubject == null)
            {
                _concreteSubject = new ConcreteSubject();
            }

            _concreteSubject.Request();
        }
    }
}
