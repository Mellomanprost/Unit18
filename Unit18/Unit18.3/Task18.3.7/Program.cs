using System;

namespace Task18._3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Печатаем баннер нужного размера на материале
            var printer = new Printer();
            printer.Start(15, "Canvas");
        }
    }
}
