using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Structural
{
    public class FinanceVisitor : Visitor
    {
        public override void Visit(FulltimeEmployee fulltime)
        {
            Console.WriteLine("The wage of fulltime is ...");
        }
        public override void Visit(ParttimeEmployee contract)
        {
            Console.WriteLine("The wage of parttime is ...");
        }
    }
}
