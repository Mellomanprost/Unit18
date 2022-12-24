using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyRealExample.Energy
{
    /// <summary>
    /// Реализация электрического отопления
    /// </summary>
    class ElectricHeater : IHeater
    {
        public void Heat()
        {
            Console.WriteLine("Нагрев электричеством");
        }
    }
}
