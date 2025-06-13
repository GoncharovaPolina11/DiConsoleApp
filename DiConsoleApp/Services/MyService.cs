using DiConsoleApp.Logging;

namespace DiConsoleApp.Services
{
    /// <summary>
    /// Реализация основного сервиса приложения
    /// </summary>
    public class MyService : IMyService
    {
        private readonly IConsoleLogger _logger;

        /// <summary>
        /// Конструктор с внедрением зависимости логгера
        /// </summary>
        /// <param name="logger">Экземпляр логгера</param>
        public MyService(IConsoleLogger logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Основной метод выполнения бизнес-логики
        /// </summary>
        public void Run()
        {
            try
            {
                // Логируем начало работы
                _logger.Log("Service started successfully!");

                // Основная логика сервиса
                _logger.Log("Hello from MyService!");

                // Можно добавить любую другую логику здесь
            }
            catch (Exception ex)
            {
                // Логируем ошибки, если они возникнут
                _logger.Log($"ERROR: {ex.Message}");
            }
        }
    }
}