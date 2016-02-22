using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessPatterns.IdentityMapPattern.Model;

namespace DataAccessPatterns.IdentityMapPattern.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private IdentityMap<Employee> _employeeMap;

        public EmployeeRepository(IdentityMap<Employee> employeeMap)
        {
            _employeeMap = employeeMap;
        }

        public Employee FindBy(Guid Id)
        {
            Employee employee = _employeeMap.GetByID(Id);

            if (employee == null)
            {
                employee = DatastoreFindBy(Id);

                if (employee != null)
                {
                    _employeeMap.Store(employee, employee.ID);
                }
            }

            return employee;
        }

        private Employee DatastoreFindBy(Guid Id)
        {
            Employee employee = default(Employee);

            // Code to hydrate employee from datastore...
            return employee;
        }
    }
}
