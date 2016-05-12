using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Practical
{
    public interface IPayment
    {
        bool Payfor(decimal money);
    }
}
