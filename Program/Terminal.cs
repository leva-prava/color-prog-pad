/**
 * @file Terminal.cs
 * @brief Содержит реализацию класса Terminal.
 */

using System;

namespace ColorProgPad
{
    /**
     * @brief Представляет класс для работы с терминалом.
     */
    class Terminal
    {
        /**
         * @brief Запускает терминал.
         */
        public void Run()
        {
            Console.WriteLine("Приветствую в терминале! Введите 'help' для получения списка команд.");

            while (true)
            {
                Console.Write("> ");
                string input = Console.ReadLine();
                ProcessCommand(input);
            }
        }

        /**
         * @brief Обрабатывает введенную команду.
         * @param command Введенная команда.
         */
        private void ProcessCommand(string command)
        {
            switch (command.ToLower())
            {
                case "help":
                    DisplayHelp();
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
                case "history":
                    DisplayHistory();
                    break;
                default:
                    Console.WriteLine("Неизвестная команда. Введите 'help' для списка команд.");
                    break;
            }
        }

        /**
         * @brief Выводит справку по доступным командам.
         */
        private void DisplayHelp()
        {
            Console.WriteLine("Список команд:");
            Console.WriteLine("- help: Выводит список команд.");
            Console.WriteLine("- exit: Завершает работу терминала.");
            Console.WriteLine("- history: Выводит историю введенных команд.");
        }

        /**
         * @brief Выводит историю введенных команд.
         */
        private void DisplayHistory()
        {
            Console.WriteLine("История команд:");
            foreach (var command in commandHistory)
            {
                Console.WriteLine(command);
            }
        }
    }

}
