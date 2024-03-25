/**
 * @file SettingM.cs
 * @brief Содержит реализацию класса SettingM.
 */

using System;
using System.Collections.Generic;

namespace ColorProgPad
{
    /**
     * @brief Представляет класс для работы с настройками.
     */
    class SettingM
    {
        private Dictionary<string, string> settings = new Dictionary<string, string>(); /**< Словарь настроек. */

        /**
         * @brief Устанавливает значение настройки.
         * @param key Ключ настройки.
         * @param value Значение настройки.
         */
        public void SetSetting(string key, string value)
        {
            settings[key] = value;
            Console.WriteLine($"Настройка \"{key}\" установлена на: {value}");
        }

        /**
         * @brief Возвращает значение настройки по ключу.
         * @param key Ключ настройки.
         * @return Значение настройки или "Не установлено", если значение не найдено.
         */
        public string GetSetting(string key)
        {
            if (settings.ContainsKey(key))
                return settings[key];
            else
                return "Не установлено";
        }
    }
}
