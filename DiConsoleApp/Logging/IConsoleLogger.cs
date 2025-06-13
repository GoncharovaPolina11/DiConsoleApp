namespace DiConsoleApp.Logging
{
    /// <summary>
    /// Интерфейс для консольного логгера
    /// </summary>
    public interface IConsoleLogger
    {
        /// <summary>
        /// Запись сообщения в лог
        /// </summary>
        /// <param name="message">Текст сообщения</param>
        void Log(string message);
    }
}