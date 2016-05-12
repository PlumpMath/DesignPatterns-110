using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Practical
{
    /// <summary>
    /// 豪华型套餐，包括鸡腿和咖啡
    /// </summary>
    public class LuxuryPackageFactory : IKFCFactory
    {
        public KFCFood CreateFood()
        {
            return new Chicken();
        }

        public KFCDrink CreateDrink()
        {
            return new Coffee();
        }
    }
}
