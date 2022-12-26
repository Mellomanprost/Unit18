using System;
using System.Threading.Tasks;

namespace Task18._4._1.Practice
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // пример ссылки, видео - https://youtu.be/Jm29kLeWqDA
            Console.WriteLine("Вставьте ссылку на видео(например - https://youtu.be/Jm29kLeWqDA):");
            var videoUrl = Console.ReadLine();
            Console.WriteLine("Укажите имя файла для скачиваемого видео:");
            var nameVideo = Console.ReadLine();
            string outputFilePath = $@"C:\SkillFactory\C#\Unit18\Unit18\Unit18.4.Practice\Task18.4.1.Practice\bin\Debug\netcoreapp3.1\{nameVideo}.mp4";

            // создадим отправителя
            var sender = new Sender();

            // создадим получателя
            var receiver = new Receiver(videoUrl, outputFilePath);

            // создание команды для получения информации
            var commandInfo = new CommandInfo(receiver);

            // инициализация команды для получения информации
            sender.SetCommand(commandInfo);

            //  выполнение команды для получения информации
            await sender.Run();

            // создание комманды для скачивания видео
            var commandDownload = new CommandDownload(receiver);

            // инициализация команды для скачивания видео
            sender.SetCommand(commandDownload);

            //  выполнение команды для скачивания видео
            await sender.Run();
        }
    }
}
