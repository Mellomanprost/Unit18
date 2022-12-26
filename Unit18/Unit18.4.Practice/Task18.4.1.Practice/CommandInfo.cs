using System.Threading.Tasks;

namespace Task18._4._1.Practice
{
    /// <summary>
    /// Реализация команды для получения информации.
    /// </summary>
    class CommandInfo : Command
    {
        Receiver receiver;

        public CommandInfo(Receiver receiver)
        {
            this.receiver = receiver;
        }

        // Выполнить
        public override async Task Run()
        {
            await receiver.GetInfo();
        }

        //// Отменить
        //public override void Cancel()
        //{ }
    }
}
