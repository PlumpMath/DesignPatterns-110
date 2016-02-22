﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Structural.ObjectAdapter
{
    public class Target : ITarget
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }
}
