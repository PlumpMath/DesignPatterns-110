﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    /*
     * 学习难度：★☆☆☆☆，使用频率：★★★★★
     * 
     * （外观模式）定义：
     * 外观模式（Facade）通过实现一个提供更合理的接口的类，可以将一个复杂的子系统变得更容易使用。
     * 
     * 适用情形：
     * 1.当要为一个复杂子系统提供一个简单接口时，子系统往往因为不断演化而变得越来越复杂。大多数模式使用时都会产生更多更小的类，这使得子系统更具可用性，也更容易对子系统进行定制。但这也给那些不需要定制子系统的用户带来一些使用上的困难。外观模式可以提供一个简单的默认视图。这一视图对大多数用户来说已经足够，而那些需要更多定制性的用户可以越过Facade层。
     * 2.客户程序与抽象类的实现部分之间存在着很大的依赖性。引入外观模式将这个子系统与客户以及其他子系统分离，可以提高该子系统的独立性和可移植性。
     * 3.当需要构建有层次结构的子系统时，使用外观模式定义每层的入口点。如果子系统间相互依赖，它们只需通过外观进行通信，从而简化它们之间的依赖关系，
     * 
     * 特点：
     * 1.它实现了子系统对客户的屏蔽，因而减少了客户处理的对象数目并且使子系统使用起来更加方便。
     * 2.它实现了子系统与客户之间的松耦合关系。而子系统内部的功能组件往往是紧耦合的。松耦合关系使得子系统的组件变化不会影响到它的客户。
     * 3.外观模式有助于建立系统的层次结构，也有助于对对象之间的依赖关系分层。
     * 4.外观模式可以消除复杂的循环依赖关系。这一点在客户程序与子系统是分别实现的时候尤为重要。在大型软件系统中降低编译依赖性至关重要。在子系统类改变时，希望尽量减少重编译工作以节省时间。
     * 5.用外观模式可以降低编译依赖性，减少对重要系统做较小的改变所需的重编译工作。
     * 6.外观模式有利于简化系统在不同平台之间的移植过程。因为编译一个子系统一般不需要编译所有其他子系统。
     * 7.如果应用需要，外观模式并不限制子系统类的使用。因此可以在系统易用性和通用性之间加以选择。
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            #region 结构实现
            Structural.Facade facade = new Structural.Facade();

            facade.MethodA();
            facade.MethodB();
            #endregion

            Console.WriteLine("******************************");

            #region 实践应用
            #endregion

            Console.ReadKey();
        }
    }
}
