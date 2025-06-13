using DiConsoleApp.Logging;
using DiConsoleApp.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DiConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Создаем контейнер зависимостей
            var services = new ServiceCollection()
                // 2. Регистрируем сервис с временным временем жизни
                .AddTransient<IMyService, MyService>()
                // 3. Регистрируем логгер как синглтон (один экземпляр на все приложение)
                .AddSingleton<IConsoleLogger, ConsoleLogger>()
                // 4. Собираем провайдер сервисов
                .BuildServiceProvider();

            // 5. Получаем экземпляр сервиса из контейнера
            var myService = services.GetRequiredService<IMyService>();

            // 6. Запускаем основной метод сервиса
            myService.Run();
        }
    }
}