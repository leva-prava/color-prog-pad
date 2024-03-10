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
    }
}

