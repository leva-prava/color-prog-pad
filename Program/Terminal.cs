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
                Console.Write("> ");
                string input = Console.ReadLine();
                ProcessCommand(input);
            }
        }

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
                default:
                    Console.WriteLine("Неизвестная команда. Введите 'help' для списка команд.");
                    break;
            }
        }
    }

}