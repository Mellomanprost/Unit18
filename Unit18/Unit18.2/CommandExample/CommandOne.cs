using System;
using System.Collections.Generic;
using System.Text;

namespace CommandExample
{
    /// <summary>
    /// Конкретная реализация команды.
    /// </summary>
    class CommandOne : Command
    {
        Receiver receiver;

        public CommandOne(Receiver receiver)
        {
            this.receiver = receiver;
        }

        // Выполнить
        public override void Run()
        {
            Console.WriteLine("Команда отправлена");
            receiver.Operation();
        }

        // Отменить
        public override void Cancel()
        { }
    }
}
