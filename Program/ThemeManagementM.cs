using System;

namespace ColorProgPad
{

    enum Theme
    {
        Light,
        Dark
    }

    class ThemeManagementM
    {
         private Theme currentTheme;

         public Theme GetCurrentTheme()
         {
            return currentTheme;
         }

         public void ApplyTheme(Theme theme)
         {
            currentTheme = theme;
            Console.WriteLine("Тема успешно изменена на: " + theme);
         }
    }
}