using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Practical
{
    public class ABCPayment : IPayment
    {
        public bool Payfor(decimal money)
        {
            // 调用中国农业银行支付接口进行支付
            return true;
        }
    }
}
