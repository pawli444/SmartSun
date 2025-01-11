using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace Projekt_IO.MWM.View
{
    public partial class LoginView : Window
    {
        private static readonly string UsersFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Projekt_IO", "users.txt");

        public LoginView()
        {
            InitializeComponent();
            EnsureUsersFileExists();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void OnLoginClick(object sender, RoutedEventArgs e)
        {
            string email = EmailBox.Text;
            string password = PasswordBox.Password;

            // Logika logowania
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Proszę wprowadzić e-mail i hasło.");
                return;
            }

            // Sprawdzenie, czy użytkownik istnieje i hasło jest poprawne
            if (ValidateUser(email, password))
            {
                MessageBox.Show("Logowanie zakończone sukcesem!");

                // Przejście do głównej strony aplikacji
                var mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nieprawidłowy e-mail lub hasło.");
            }
        }

        private void OnRegisterClick(object sender, RoutedEventArgs e)
        {
            // Przejście do widoku rejestracji
            RegisterView registerView = new RegisterView();
            registerView.Show();
            this.Close();
        }

        private bool ValidateUser(string email, string password)
        {
            if (!File.Exists(UsersFilePath))
            {
                return false;
            }

            var lines = File.ReadAllLines(UsersFilePath);
            string passwordHash = ComputeHash(password);
            foreach (var line in lines)
            {
                var parts = line.Split(':');
                if (parts[0] == email && parts[1] == passwordHash)
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
