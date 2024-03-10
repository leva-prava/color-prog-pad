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
            // Реализация обработки команд
            Console.WriteLine($"Вы ввели команду: {command}");
        }
    }

}