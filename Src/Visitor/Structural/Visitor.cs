using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Structural
{
    public abstract class Visitor
    {
        public abstract void Visit(FulltimeEmployee fulltime);
        public abstract void Visit(ParttimeEmployee contract);
    }
}
