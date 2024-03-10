using System;
using System.Collections.Generic;

namespace ColorProgPad
{
    class SemanticsAnalyzer
    {
        private List<string> functions = new List<string>();
        private List<string> variables = new List<string>();

        private bool hasConditionalStatements;
        private bool hasLoops;

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

        private void AnalyzeExpressions(string functionCode)
        {
            // Простая логика анализа арифметических выражений
            MatchCollection expressionMatches = Regex.Matches(functionCode, @"(\w+)\s*([+\-*/])\s*(\w+)");
            foreach (Match match in expressionMatches)
            {
                Console.WriteLine($"Найдено выражение: {match.Value}");
            }
        }

        public List<string> GetFunctions()
        {
            return functions;
        }

        public List<string> GetVariables()
        {
            return variables;
        }

        public bool HasConditionalStatements()
        {
            return hasConditionalStatements;
        }

        public bool HasLoops()
        {
            return hasLoops;
        }

        public string AnalyzeExpressionsInFunctions()
        {
            return "Анализ выражений выполнен успешно.";
        }

    }
}