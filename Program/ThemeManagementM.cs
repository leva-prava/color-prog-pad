/**
 * @file ThemeManagementM.cs
 * @brief Содержит реализацию класса ThemeManagementM.
 */

using System;

namespace ColorProgPad
{

    /**
     * @brief Представляет темы интерфейса.
     */
    enum Theme
    {
        Light, /**< Светлая тема. */
        Dark   /**< Тёмная тема. */
    }


    /**
     * @brief Представляет менеджер тем.
     */
    class ThemeManagementM
    {
        private Theme currentTheme;
        private readonly System.Collections.Generic.Dictionary<Theme, ThemeStyles> themeStylesDictionary;

        /**
         * @brief Конструктор по умолчанию.
         */
        public ThemeManagementM()
        {
            themeStylesDictionary = new System.Collections.Generic.Dictionary<Theme, ThemeStyles>();
        }

        /**
         * @brief Применяет указанную тему.
         * @param theme Тема, которую следует применить.
         */
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

        /**
         * @brief Конфигурирует стили для указанной темы.
         * @param theme Тема, для которой требуется настроить стили.
         * @param styles Стили, которые следует применить.
         */
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

        /**
         * @brief Выводит информацию о текущей теме.
         */
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

        /**
         * @brief Применяет стили текущей темы.
         */
        private void ApplyStyles()
        {
            if (themeStylesDictionary.ContainsKey(currentTheme))
            {
                ThemeStyles currentStyles = themeStylesDictionary[currentTheme];
                Console.BackgroundColor = currentStyles.BackgroundColor;
                Console.ForegroundColor = currentStyles.ForegroundColor;
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Ошибка: Настройки для текущей темы не найдены.");
            }
        }
    }
}
