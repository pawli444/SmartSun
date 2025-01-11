using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using Projekt_IO.MWM.ViewModel;
using Projekt_IO.Services;

namespace Projekt_IO.MWM.View
{
    public partial class AddPlant : Window
    {
        public BitmapImage PlantImage { get; private set; }
        public string PlantName { get; private set; }

        public AddPlant()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void OnCloseClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        
        //dodawanie zdjecia z komputera
        private void OnUploadClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Pliki obrazów|*.jpg;*.jpeg;*.png"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                // Wczytaj obraz i wyświetl go w obszarze podglądu
                PlantImage = new BitmapImage(new Uri(openFileDialog.FileName));
                PreviewImage.Source = PlantImage;

                // Zmień tekst przycisku, aby poinformować, że zdjęcie zostało dodane
                (sender as Button).Content = "Zdjęcie dodane!";
            }
        }

        // Obsługa przycisku "Dodaj"
        private void OnAddClick(object sender, RoutedEventArgs e)
        {
            // Pobierz dane z TextBox
            var textBox = (TextBox)this.FindName("PlantNameTextBox");
            if (textBox != null)
            {
                PlantName = textBox.Text;
            }

            // Zamknij okno
            this.Close();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
    }
}
