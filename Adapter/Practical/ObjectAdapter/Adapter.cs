using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Practical.ObjectAdapter
{
    public class Adapter : ITarget
    {
        public Power _power;
        public Adapter(Power power)
        {
            this._power = power;
        }

        /// <summary>
        /// 得到想要的电压
        /// </summary>
        public void GetPower()
        {
            _power.GetPower220V();
            Console.WriteLine("得到手机的充电电压！");
        }
    }
}
