/**
 * @file SearchM.cs
 * @brief Содержит реализацию класса SearchM.
 */

using System;
using System.Text.RegularExpressions;

namespace ColorProgPad
{
    /**
     * @brief Класс для отвечающий за поиск и замену текста.
     */
    class SearchM
    {
        /**
         * @brief Осуществляет поиск заданной строки в коде.
         * @param code Код, в котором осуществляется поиск.
         * @param searchTerm Текст, который необходимо найти.
         * @param caseSensitive Определяет, должен ли поиск быть регистро-зависимым.
         * @return Сообщение о том, найден ли текст.
         */
        public string Search(string code, string searchTerm, bool caseSensitive = false)
        {
            StringComparison comparison = caseSensitive ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase;
            // Поиск строки в коде
            return code.Contains(searchTerm) ? $"Найдено: {searchTerm}" : $"Не найдено: {searchTerm}";
        }

        /**
         * @brief Заменяет все вхождения заданного текста текстом-заменой в коде.
         * @param code Код, в котором выполняется замена.
         * @param searchTerm Текст, который необходимо заменить.
         * @param replacement Строка, которой необходимо заменить указанный текст.
         * @return Код с примененными заменами.
         */
        public string Replace(string code, string searchTerm, string replacement)
        {
            StringComparison comparison = caseSensitive ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase;

            string replacedCode = code.Replace(searchTerm, replacement);
            return replacedCode;
        }

        /**
         * @brief Заменяет все вхождения заданного регулярного выражения заменой в предоставленном коде.
         * @param code Код, в котором выполняется замена.
         * @param pattern Регулярное выражение, которое необходимо найти.
         * @param replacement Строка, которой необходимо заменить вхождения регулярного выражения.
         * @return Код с примененными заменами.
         */
        public string ReplaceUsingRegex(string code, string pattern, string replacement)
        {
            string replacedCode = Regex.Replace(code, pattern, replacement);
            return replacedCode;
        }

        /**
         * @brief Подсчитывает количество вхождений заданного текста в предоставленном коде.
         * @param code Код, в котором осуществляется поиск.
         * @param searchTerm Текст, который необходимо найти.
         * @param caseSensitive Определяет, должен ли поиск быть регистро-зависимым.
         * @return Количество вхождений термина.
         */
        public int CountOccurrences(string code, string searchTerm, bool caseSensitive = false)
        {
            StringComparison comparison = caseSensitive ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase;

            // Подсчёт количества вхождений
            int count = 0;
            int index = 0;

            while ((index = code.IndexOf(searchTerm, index, comparison)) != -1)
            {
                index += searchTerm.Length;
                count++;
            }

            return count;
        }

        /**
         * @brief Отображает контекст вокруг вхождений заданного текста в предоставленном коде.
         * @param code Код, в котором осуществляется поиск.
         * @param searchTerm Текст, который необходимо найти.
         * @param contextLength Длина контекста вокруг каждого вхождения.
         * @return Контекст вокруг каждого вхождения термина.
         */
        public string DisplayContext(string code, string searchTerm, int contextLength)
        {
            // Отображение контекста вокруг найденных совпадений
            int index = 0;
            string contextResult = "";

            while ((index = code.IndexOf(searchTerm, index, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                int start = Math.Max(0, index - contextLength);
                int end = Math.Min(code.Length, index + searchTerm.Length + contextLength);

                contextResult += code.Substring(start, end - start) + Environment.NewLine;

                index += searchTerm.Length;
            }

            return contextResult.Trim();
        }
    }
}