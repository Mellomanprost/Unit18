﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyExample
{
    /// <summary>
    /// Первая реализация алгоритма
    /// </summary>
    public class StrategyOne : IStrategy
    {
        public void Algorithm()
        { }
    }

    /// <summary>
    /// Вторая реализация алгоритма
    /// </summary>
    public class StrategyTwo : IStrategy
    {
        public void Algorithm()
        { }
    }
}
