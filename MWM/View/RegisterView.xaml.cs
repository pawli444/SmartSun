using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace Projekt_IO.MWM.View
{
    public partial class RegisterView : Window
    {
        private static readonly string UsersFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Projekt_IO", "users.txt");

        public RegisterView()
        {
            InitializeComponent();
            EnsureUsersFileExists();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void OnRegisterClick(object sender, RoutedEventArgs e)
        {
            string email = EmailBox.Text;
            string password = PasswordBox.Password;
            string confirmPassword = ConfirmPasswordBox.Password;

            // Logika rejestracji
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Proszę wprowadzić e-mail i hasło.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Hasła nie są zgodne.");
                return;
            }

            // Sprawdzenie, czy użytkownik już istnieje
            if (UserExists(email))
            {
                MessageBox.Show("Użytkownik o tym e-mailu już istnieje.");
                return;
            }

            // Zapisanie użytkownika do pliku tekstowego
            try
            {
                string passwordHash = ComputeHash(password);
                File.AppendAllText(UsersFilePath, $"{email}:{passwordHash}{Environment.NewLine}");
                MessageBox.Show("Rejestracja zakończona sukcesem!");

                // Przejście do głównej strony aplikacji
                var mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas rejestracji: {ex.Message}");
            }
        }

        private void OnLoginClick(object sender, RoutedEventArgs e)
        {
            // Przejście do widoku logowania
            LoginView loginView = new LoginView();
            loginView.Show();
            this.Close();
        }

        private bool UserExists(string email)
        {
            if (!File.Exists(UsersFilePath))
            {
                return false;
            }

            var lines = File.ReadAllLines(UsersFilePath);
            foreach (var line in lines)
            {
                var parts = line.Split(':');
                if (parts[0] == email)
                {
                    return true;
                }
            }

            return false;
        }

        private string ComputeHash(string input)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                var builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void EnsureUsersFileExists()
        {
            string directoryPath = Path.GetDirectoryName(UsersFilePath);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            if (!File.Exists(UsersFilePath))
            {
                File.Create(UsersFilePath).Close();
            }
        }
    }
}
