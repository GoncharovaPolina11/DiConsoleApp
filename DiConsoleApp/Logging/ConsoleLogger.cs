namespace DiConsoleApp.Logging
{
    /// <summary>
    /// Реализация консольного логгера с цветным выводом
    /// </summary>
    public class ConsoleLogger : IConsoleLogger
    {
        /// <summary>
        /// Метод логирования сообщения с временной меткой
        /// </summary>
        /// <param name="message">Текст сообщения</param>
        public void Log(string message)
        {
            // Сохраняем текущий цвет консоли
            var originalColor = Console.ForegroundColor;

            // Устанавливаем цвет для временной метки
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write($"[{DateTime.Now:HH:mm:ss}] ");

            // Возвращаем исходный цвет для сообщения
            Console.ForegroundColor = originalColor;
            Console.WriteLine(message);
        }
    }
}