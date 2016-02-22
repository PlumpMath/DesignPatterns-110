using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Structural
{
    public class ConcreteFactoryB : Factory
    {
        public override Product CreateProduct()
        {
            return new ConcreteProductB();
        }
    }
}
