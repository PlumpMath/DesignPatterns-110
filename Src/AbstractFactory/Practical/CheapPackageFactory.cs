using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Practical
{
    /// <summary>
    /// 经济型套餐，包括鸡翅和可乐
    /// </summary>
    public class CheapPackageFactory : IKFCFactory
    {
        public KFCFood CreateFood()
        {
            return new Wings();
        }
        public KFCDrink CreateDrink()
        {
            return new Coke();
        }
    }
}
