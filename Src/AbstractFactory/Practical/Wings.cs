using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Practical
{
    public class Wings : KFCFood
    {
        public override void Display()
        {
            Console.WriteLine("鸡翅 + 1");
        }
    }
}
