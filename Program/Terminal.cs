using System;

namespace ColorProgPad
{
    class Terminal
    {
        public void Run()
        {
            Console.WriteLine("Приветствую в терминале! Введите 'help' для получения списка команд.");

            while (true)
            {
                Console.Write("<--> ");
                string input = Console.ReadLine();
                ProcessCommand(input);
            }
        }

        private void ProcessCommand(string command)
        {
            switch (command.ToLower())
            {
                case "help++":
                    DisplayHelp();
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
                case "history cmd":
                    DisplayHistory();
                    break;
                default:
                    Console.WriteLine("Неизвестная команда. Введите 'help' для списка команд.");
                    break;
            }
        }

        private void DisplayHelp()
        {
            Console.WriteLine("Список команд:");
            Console.WriteLine("- help: Выводит список команд.");
            Console.WriteLine("- exit: Завершает работу терминала.");
            Console.WriteLine("- history: Выводит историю введенных команд.");
        }

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