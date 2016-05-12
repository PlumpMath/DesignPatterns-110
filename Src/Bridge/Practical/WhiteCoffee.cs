﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Practical
{
    /// <summary>
    /// 牛奶咖啡
    /// </summary>
    public class WhiteCoffee : MakeCoffee
    {
        public override void Making()
        {
            Console.WriteLine("牛奶咖啡");
        }
    }
}
