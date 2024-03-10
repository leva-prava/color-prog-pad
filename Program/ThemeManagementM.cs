using System;

namespace ColorProgPad
{

    enum Theme
    {
        Light,
        Dark
    }

    class ThemeStyles
    {
        public ConsoleColor BackgroundColor { get; set; }
        public ConsoleColor ForegroundColor { get; set; }
        public int FontSize { get; set; }
    }

    class ThemeManagementM
    {
         private Theme currentTheme;
        private readonly System.Collections.Generic.Dictionary<Theme, ThemeStyles> themeStylesDictionary;

         public ThemeManager()
        {
            themeStylesDictionary = new System.Collections.Generic.Dictionary<Theme, ThemeStyles>();
        }

        public void ApplyTheme(Theme theme)
        {
            if (themeStylesDictionary.ContainsKey(theme))
            {
                currentTheme = theme;
                ApplyStyles();
                Console.WriteLine("Тема успешно изменена на: " + theme);
            }
            else
            {
                Console.WriteLine("Ошибка: Настройки для темы не найдены.");
            }
        }

        public void ConfigureThemeStyles(Theme theme, ThemeStyles styles)
        {
            if (!themeStylesDictionary.ContainsKey(theme))
            {
                themeStylesDictionary.Add(theme, styles);
                Console.WriteLine($"Настройки для темы {theme} успешно добавлены.");
            }
            else
            {
                themeStylesDictionary[theme] = styles;
                Console.WriteLine($"Настройки для темы {theme} успешно обновлены.");
            }
        }

        public void PrintCurrentTheme()
        {
            Console.WriteLine($"Текущая тема: {currentTheme}");
            if (themeStylesDictionary.ContainsKey(currentTheme))
            {
                ThemeStyles currentStyles = themeStylesDictionary[currentTheme];
                Console.WriteLine($"Фон: {currentStyles.BackgroundColor}, Текст: {currentStyles.ForegroundColor}, Размер шрифта: {currentStyles.FontSize}");
            }
            else
            {
                Console.WriteLine("Ошибка: Настройки для текущей темы не найдены.");
            }
        }

        private void ApplyStyles(int height, int width)
        {
            if (themeStylesDictionary.ContainsKey(currentTheme))
            {
                ThemeStyles currentStyles = themeStylesDictionary[currentTheme];
                Console.BackgroundColor = currentStyles.BackgroundColor;
                Console.ForegroundColor = currentStyles.ForegroundColor;
                Console.WindowHeight = height;
                Console.WindowWidth = width; 
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Ошибка: Настройки для текущей темы не найдены.");
            }
        }
    }
}