using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Projekt_IO
{
    public static class ThemeManager
    {
        private static string _currentTheme = "LightTheme";

        public static void ApplyTheme(string themeKey)
        {
            var appResources = Application.Current.Resources;

            if (_currentTheme == themeKey)
                return;

            if (themeKey == "LightTheme")
            {
                //jasny motyw
                appResources["AppBackgroundBrush"] = new SolidColorBrush((Color)appResources["LightBackgroundColor"]);
                appResources["AppForegroundBrush"] = new SolidColorBrush((Color)appResources["LightForegroundColor"]);
                appResources["AppExtension"] = new SolidColorBrush((Color)appResources["LightExtensions"]);
                appResources["Separator"] = new SolidColorBrush((Color)appResources["LightSeparator"]);
                appResources["Image1"] = appResources["LightImage1"];
                appResources["Image2"] = appResources["LightImage2"];
                appResources["Image3"] = appResources["LightImage3"];
            }
            else if (themeKey == "DarkTheme")
            {
                //ciemny motyw
                appResources["AppBackgroundBrush"] = new SolidColorBrush((Color)appResources["DarkBackgroundColor"]);
                appResources["AppForegroundBrush"] = new SolidColorBrush((Color)appResources["DarkForegroundColor"]);
                appResources["AppExtension"] = new SolidColorBrush((Color)appResources["DarkExtensions"]);
                appResources["Separator"] = new SolidColorBrush((Color)appResources["DarkSeparator"]);
                appResources["Image1"] = appResources["DarkImage1"];
                appResources["Image2"] = appResources["DarkImage2"];
                appResources["Image3"] = appResources["DarkImage3"];
            }
            else
            {
                throw new ArgumentException($"Nieznany motyw: {themeKey}");
            }

            _currentTheme = themeKey;
        }

        //ustawienie motywu ciemny/jasny
        public static void SetTheme(bool isDarkTheme)
        {
            ApplyTheme(isDarkTheme ? "DarkTheme" : "LightTheme");
        }
    }
}
