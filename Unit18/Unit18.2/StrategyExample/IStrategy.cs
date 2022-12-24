using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyExample
{
    /// <summary>
    /// Общий интерфейс некоего алгоритма
    /// </summary>
    public interface IStrategy
    {
        void Algorithm();
    }
}
