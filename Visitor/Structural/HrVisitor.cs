using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Structural
{
    class HrVisitor : Visitor
    {
        public override void Visit(FulltimeEmployee fulltime)
        {
            Console.Write("The worktime of fulltime is ...");
            Console.Write("The overtime of fulltime is ...");
            Console.Write("The timeoff of fulltime is ...");
        }
        public override void Visit(ParttimeEmployee contract)
        {
            Console.Write("The worktime of fulltime is ...");
        }
    }
}
