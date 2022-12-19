using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderRealExample.Builders;
using BuilderRealExample.PageModel;

namespace BuilderRealExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // создаем движок шаблонизатора
            TemplateEngine templateEngine = new TemplateEngine();

            // создаем шаблонизатор для приветственной рассылки
            TemplateBuilder builder = new WelcomeTemplateBuilder();
            // генерируем  приветственное письмо с текстом
            Template greetingsTemplate = templateEngine.GenerateTemplate(builder);
            Console.WriteLine(greetingsTemplate.ToString());


            // переопределяем шаблонизатор для рассылки с номером заказа
            builder = new OrderTemplateBuilder();
            // генерируем  письмо  с номером заказа
            Template orderTemplate = templateEngine.GenerateTemplate(builder);
            Console.WriteLine(orderTemplate.ToString());
        }
    }
}

