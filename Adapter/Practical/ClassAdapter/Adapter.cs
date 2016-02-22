using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Practical.ClassAdapter
{
    public class Adapter : Power, ITarget
    {
        public void GetPower()
        {
            this.GetPower220V();
            Console.WriteLine("得到手机的充电电压！");
        }
    }
}
