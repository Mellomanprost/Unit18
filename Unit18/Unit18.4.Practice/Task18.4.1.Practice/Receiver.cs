using System;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace Task18._4._1.Practice
{
    /// <summary>
    /// Адресат команды
    /// </summary>
    class Receiver
    {
        protected string VideoUrl;
        protected string OutputFilePath;

        YoutubeClient videoClient = new YoutubeClient();

        public Receiver(string videoUrl, string outputfilePath)
        {
            VideoUrl = videoUrl;
            OutputFilePath = outputfilePath;
        }

        // Метод для получение информации о видео
        public async Task GetInfo()
        {
            Console.WriteLine("Получение информации о видео...");
            // получить описание видео
            var video = await videoClient.Videos.GetAsync(VideoUrl);
            // Вывод информации о видео в консоль
            Console.WriteLine($"Название:\n{video.Title}\nОписание видео:\n{video.Description}\nСоздатель:\n{video.Author.ChannelTitle}\nДлительность:\n{video.Duration}");
        }

        // Метод для скачивания видео
        public async Task DownloadVideo()
        {
            Console.WriteLine("Скачивание начинается...");
            // запустить скачивание видео
            await videoClient.Videos.DownloadAsync(VideoUrl, OutputFilePath);
            Console.WriteLine("Скачивание завершено!");
        }

    }
}
