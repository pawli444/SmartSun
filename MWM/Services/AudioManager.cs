using System;
using System.Media;
using System.IO;

namespace Projekt_IO.Services
{
    public class AudioManager
    {
        private static bool _isMuted = false;

        public static void SetMute(bool mute)
        {
            _isMuted = mute;
            Console.WriteLine(_isMuted ? "Wyciszone dźwięki" : "Włączone dźwięki");
        }

        public static void PlaySound(string filePath)
        {
            if (_isMuted) return;

            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Plik dźwiękowy nie znaleziony: {filePath}");
                return;
            }

            try
            {
                using (var soundPlayer = new SoundPlayer(filePath))
                {
                    soundPlayer.Play();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd odtwarzania dźwięku: {ex.Message}");
            }
        }

        public static bool IsMuted()
        {
            return _isMuted;
        }
    }
}
