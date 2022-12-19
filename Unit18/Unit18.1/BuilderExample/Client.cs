using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExample
{
    class Client
    {
        static void Main()
        {
            // инициализация строителя
            IBuilder builder = new ProductBuilder();
            // Создаем менеджера, который будет рулить процессом
            BuildManager buildManager = new BuildManager(builder);

            //  Стартуем и получаем результат
            buildManager.StartBuildingProcess();
            Product product = builder.GetBuildingResult();
        }
    }
}
