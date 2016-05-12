using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Practical.ClassAdapter
{
    public class Power
    {
        public void GetPower220V()
        {
            Console.WriteLine("从电源中得到220V的电压");
        }
    }
}
