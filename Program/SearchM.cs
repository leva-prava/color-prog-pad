using System;

namespace ColorProgPad
{
    class SearchM
    {
        public string Search(string code, string searchTerm)
        {
            StringComparison comparison = caseSensitive ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase;
            //Поиск строки в коде
            return code.Contains(searchTerm) ? $"Найдено: {searchTerm}" : $"Не найдено: {searchTerm}";
        }

        public string Replace(string code, string searchTerm, string replacement)
        {
            StringComparison comparison = caseSensitive ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase;

            string replacedCode = code.Replace(searchTerm, replacement);
            return replacedCode;
        }

        public string ReplaceUsingRegex(string code, string pattern, string replacement)
        {
            string replacedCode = Regex.Replace(code, pattern, replacement);
            return replacedCode;
        }

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

        public string DisplayContext(string code, string searchTerm, int contextLength)
        {
            // Отображение контекста вокруг найденых совпадений
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

