using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Practical
{
    public class Coffee : KFCDrink
    {
        public override void Display()
        {
            Console.WriteLine("咖啡 + 1");
        }
    }
}
