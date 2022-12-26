using System.Threading.Tasks;

namespace Task18._4._1.Practice
{
    /// <summary>
    /// Базовый класс команды
    /// </summary>
    abstract class Command
    {
        public abstract Task Run();
        //public abstract void Cancel();
    }
}
