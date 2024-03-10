using System;
using System.Collections.Generic;

namespace ColorProgPad
{
    class SettingM
    {
        private Dictionary<string, string> settings = new Dictionary<string, string>();

        public void SetSetting(string key, string value)
        {
            settings[key] = value;
            Console.WriteLine($"Настройка \"{key}\" установлена на: {value}");
        }

        public string GetSetting(string key)
        {
            if (settings.ContainsKey(key))
                return settings[key];
            else
                return "Не установлено";
        }
    }
}