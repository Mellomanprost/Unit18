using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyRealExample
{
    /// <summary>
    /// Общий интерфейс отопительных котлов
    /// </summary>
    interface IHeater
    {
        //  Нагрев
        void Heat();
    }
}
