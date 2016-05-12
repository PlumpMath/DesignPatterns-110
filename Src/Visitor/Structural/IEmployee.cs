using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Structural
{
    public interface IEmployee
    {
        void Accept(Visitor visitor);

        String Name { set; get; }
        Int32 Wage { set; get; }
    }
}
