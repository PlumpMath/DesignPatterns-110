﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Structural
{
    /// <summary>
    /// 单件模式实现方式
    /// </summary>
    public sealed class Singleton
    {
        private static Singleton _instance;
        private static readonly object _syncLock = new object();

        // 将构造函数设为private，防止通过new实例化对象
        private Singleton() { }

        // 获取实例，并加入判断逻辑，保证实例只被创建一次
        public static Singleton Instance()
        {
            // 使用延迟初始化
            // 注: 非线程安全
            if (_instance == null)
            {
                lock (_syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();    
                    }
                }
                
            }

            return _instance;
        }
    }
}
