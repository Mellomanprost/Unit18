using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyRealExample.Energy
{
    /// <summary>
    ///  Реализация газового отопления
    /// </summary>
    class GasHeater : IHeater
    {
        public void Heat()
        {
            Console.WriteLine("Нагрев газом");
        }
    }
}
