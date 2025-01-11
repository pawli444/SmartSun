using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using Projekt_IO.Services;

namespace Projekt_IO.MWM.ViewModel
{
    public class UstawieniaViewModel : INotifyPropertyChanged
    {
        private bool _isNoiseMuted;
        private bool _isDarkMode;

        public bool IsNoiseMuted
        {
            get => _isNoiseMuted;
            set
            {
                if (_isNoiseMuted != value)
                {
                    _isNoiseMuted = value;
                    OnPropertyChanged();
                    SaveSettings();
                    AudioManager.SetMute(_isNoiseMuted);
                }
            }
        }

        public bool IsDarkMode
        {
            get => _isDarkMode;
            set
            {
                Console.WriteLine($"IsDarkMode changing from {_isDarkMode} to {value}");  // Logowanie zmiany

                if (_isDarkMode != value)
                {
                    _isDarkMode = value;
                    OnPropertyChanged();
                    ThemeManager.ApplyTheme(_isDarkMode ? "DarkTheme" : "LightTheme");
                    SaveSettings();  // Zapisywanie zmian
                }
            }
        }
        public UstawieniaViewModel()
        {
            IsNoiseMuted = Properties.Settings.Default.IsNoiseMuted;
            IsDarkMode = Properties.Settings.Default.IsDarkMode;
            Console.WriteLine($"Loaded settings: IsNoiseMuted = {IsNoiseMuted}, IsDarkMode = {IsDarkMode}");

            // Aplikacja odpowiedniego motywu na podstawie zapisanego ustawienia
            ThemeManager.ApplyTheme(IsDarkMode ? "DarkTheme" : "LightTheme");
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.IsNoiseMuted = _isNoiseMuted;
            Properties.Settings.Default.IsDarkMode = _isDarkMode;
            Properties.Settings.Default.Save();
            Console.WriteLine($"Settings saved: IsNoiseMuted = {IsNoiseMuted}, IsDarkMode = {IsDarkMode}");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            Console.WriteLine($"PropertyChanged: {propertyName}");
        }
    }
}
