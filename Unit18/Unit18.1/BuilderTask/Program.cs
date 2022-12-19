using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderTask.Conveyors;

namespace BuilderTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // создаем завод для производства
            var carPlant = new CarPlant();

            // создаем конвеер по производству скутеров
            Conveyor conveyor = new ScooterConveyor();
            carPlant.Construct(conveyor);
            conveyor.Product.Show();

            // переоборудовываем конвеер для производства автомобилей
            conveyor = new CarConveyor();
            carPlant.Construct(conveyor);
            conveyor.Product.Show();

            // переоборудовываем конвеер для производства мотоциклов
            conveyor = new MotoConveyor();
            carPlant.Construct(conveyor);
            conveyor.Product.Show();

        }
    }
}
