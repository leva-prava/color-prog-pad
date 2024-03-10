using System;

namespace ColorProgPad
{
    class SearchM
    {
        public string Search(string code, string searchTerm)
        {
            //Поиск строки в коде
            return code.Contains(searchTerm) ? $"Найдено: {searchTerm}" : $"Не найдено: {searchTerm}";
        }

        public string Replace(string code, string searchTerm, string replacement)
        {
            string replacedCode = code.Replace(searchTerm, replacement);
            return replacedCode;
        }
    }
}

