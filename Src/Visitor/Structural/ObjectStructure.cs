using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Structural
{
    public class ObjectStructure
    {
        public void Accept(Visitor visitor)
        {
            foreach (IEmployee element in employees)
            {
                element.Accept(visitor);
            }
        }

        public void AddEmployee(IEmployee employee)
        {
            employees.Add(employee);
        }

        public void RemoveEmployee(IEmployee employee)
        {
            employees.Remove(employee);
        }

        private List<IEmployee> employees = new List<IEmployee>();
    }
}
