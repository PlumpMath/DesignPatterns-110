using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Practical
{
    /// <summary>
    /// 抽象工厂，生产套餐
    /// </summary>
    public interface IKFCFactory
    {
        KFCFood CreateFood();
        KFCDrink CreateDrink();
    }
}
