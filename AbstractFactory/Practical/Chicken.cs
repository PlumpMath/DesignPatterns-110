using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Practical
{
    public class Chicken : KFCFood
    {
        public override void Display()
        {
            Console.WriteLine("鸡腿 + 1");
        }
    }
}
