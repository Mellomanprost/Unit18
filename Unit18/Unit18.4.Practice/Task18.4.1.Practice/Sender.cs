using System.Threading.Tasks;

namespace Task18._4._1.Practice
{
    /// <summary>
    /// Отправитель команды
    /// </summary>
    class Sender
    {
        Command _command;

        public void SetCommand(Command command)
        {
            _command = command;
        }

        // Выполнить
        public async Task Run()
        {
            await _command.Run();
        }

        //// Отменить
        //public void Cancel()
        //{
        //    _command.Cancel();
        //}
    }
}
