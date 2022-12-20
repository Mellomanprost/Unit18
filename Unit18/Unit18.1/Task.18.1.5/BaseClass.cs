using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._18._1._5
{
    /// <summary>
    /// Общий базовый интерфейс(класс) для объектов
    /// </summary>
    public abstract class BaseClass
    {
        protected int Id { get; }

        // Метод конструктор
        public BaseClass(int id)
        {
            Id = id;
        }

        // Метод для клонирования
        public abstract BaseClass Clone();

        // Метод для получения информации об объекте
        public void GetId()
        {
            Console.WriteLine($"Создан объект с Id {Id}");
        }
    }
}
