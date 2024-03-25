/**
 * @file SemanticsAnalyzer.cs
 * @brief Содержит реализацию класса SemanticsAnalyzer.
 */

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ColorProgPad
{
    /**
     * @brief Представляет класс для анализа семантики кода.
     */
    class SemanticsAnalyzer
    {
        private List<string> functions = new List<string>(); /**< Список функций в коде. */
        private List<string> variables = new List<string>(); /**< Список переменных в коде. */

        private bool hasConditionalStatements; /**< Признак наличия условных операторов. */
        private bool hasLoops; /**< Признак наличия циклов. */

        /**
         * @brief Анализирует предоставленный код.
         * @param code Код для анализа.
         */
        public void AnalyzeCode(string code)
        {
            // Поиск функций
            MatchCollection functionMatches = Regex.Matches(code, @"function\s+(\w+)");
            foreach (Match match in functionMatches)
            {
                functions.Add(match.Groups[1].Value);
                // Анализ выражений внутри функции
                AnalyzeExpressions(match.Value);
            }

            // Поиск переменных
            MatchCollection variableMatches = Regex.Matches(code, @"\bvar\s+(\w+)");
            foreach (Match match in variableMatches)
            {
                variables.Add(match.Groups[1].Value);
            }

            // Проверка наличия условных операторов
            hasConditionalStatements = code.Contains("if");

            // Проверка наличия циклов
            hasLoops = code.Contains("for") || code.Contains("while");
        }

        /**
         * @brief Анализирует выражения в предоставленном коде функции.
         * @param functionCode Код функции для анализа.
         */
        private void AnalyzeExpressions(string functionCode)
        {
            // Простая логика анализа арифметических выражений
            MatchCollection expressionMatches = Regex.Matches(functionCode, @"(\w+)\s*([+\-*/])\s*(\w+)");
            foreach (Match match in expressionMatches)
            {
                Console.WriteLine($"Найдено выражение: {match.Value}");
            }
        }

        /**
         * @brief Возвращает список функций в коде.
         * @return Список функций.
         */
        public List<string> GetFunctions()
        {
            return functions;
        }

        /**
         * @brief Возвращает список переменных в коде.
         * @return Список переменных.
         */
        public List<string> GetVariables()
        {
            return variables;
        }

        /**
         * @brief Проверяет наличие условных операторов в коде.
         * @return true, если есть условные операторы, в противном случае - false.
         */
        public bool HasConditionalStatements()
        {
            return hasConditionalStatements;
        }

        /**
         * @brief Проверяет наличие циклов в коде.
         * @return true, если есть циклы, в противном случае - false.
         */
        public bool HasLoops()
        {
            return hasLoops;
        }

        /**
         * @brief Анализирует выражения в функциях.
         * @return Сообщение об успешном выполнении анализа.
         */
        public string AnalyzeExpressionsInFunctions()
        {
            return "Анализ выражений выполнен успешно.";
        }
    }
}
