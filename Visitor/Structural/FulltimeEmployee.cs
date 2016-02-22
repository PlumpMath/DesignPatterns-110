using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Structural
{
    public class FulltimeEmployee : IEmployee
    {
        public FulltimeEmployee(String name, Int32 wage)
        {
            this._name = name;
            this._wage = wage;
        }

        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }

        public void OperationFulltime()
        { }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Wage
        {
            get { return _wage; }
            set { _wage = value; }
        }

        private String _name;
        private Int32 _wage;
    }
}
