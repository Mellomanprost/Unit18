using System;
using System.Collections.Generic;
using System.Text;

namespace CommandExample
{
    /// <summary>
    /// Базовый класс команды
    /// </summary>
    abstract class Command
    {
        public abstract void Run();
        public abstract void Cancel();
    }
}
