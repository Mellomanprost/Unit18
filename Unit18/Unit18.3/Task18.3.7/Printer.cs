using System;
using System.Collections.Generic;
using System.Text;

namespace Task18._3._7
{
    public class Printer
    {
        /// <summary>
        ///  Запуск принтера
        /// </summary>
        public void Start(int size, string material)
        {
            //  печать информации о материале
            PrintInfo(material);

            // печать на разных носителях в зависимости от размера
            PrintSize(size);
        }

        static void PrintInfo(string material)
        {
            Console.WriteLine($"Awesome Print on {material}!");
        }

        static void PrintSize(int size)
        {
            string sizeCode;
            string sizeName;

            if (size < 10)
            {
                sizeCode = "M";
                sizeName = "medium";
            }
            else if (size < 90)
            {
                sizeCode = "L";
                sizeName = "large";
            }
            else
            {
                sizeCode = "XL";
                sizeName = "extra large";
            }

            Console.WriteLine($"Size {sizeCode}");
            Console.WriteLine($"printing on {sizeName} canvas.");
        }
    }
}
