using System.Threading.Tasks;

namespace Task18._4._1.Practice
{
    /// <summary>
    /// Реализация команды для скачивания видео.
    /// </summary>
    class CommandDownload : Command
    {
        Receiver receiver;

        public CommandDownload(Receiver receiver)
        {
            this.receiver = receiver;
        }

        // Выполнить
        public override async Task Run()
        {
            await receiver.DownloadVideo();
        }

        //// Отменить
        //public override void Cancel()
        //{ }
    }
}
