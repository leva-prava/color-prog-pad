using System;
using System.Collections.Generic;

namespace ColorProgPad
{
    class SemanticsAnalyzer
    {
        private List<string> functions = new List<string>();
        private List<string> variables = new List<string>();

        public void AnalyzeCode(string code)
        {
             if (code.Contains("function"))
            {
                //пример добавления функции анализатором
                functions.Add("add");
            }

            if (code.Contains("var"))
            {
                // пример добавления переменной анализатором
                variables.Add("a");
                variables.Add("b");
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
    }
}