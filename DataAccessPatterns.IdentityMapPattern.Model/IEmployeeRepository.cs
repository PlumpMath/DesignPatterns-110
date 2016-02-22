using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessPatterns.IdentityMapPattern.Model
{
    public interface IEmployeeRepository
    {
        Employee FindBy(Guid ID);
    }
}
