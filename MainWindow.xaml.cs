using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Projekt_IO.MWM.ViewModel;
using Projekt_IO.Services;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Media;

namespace Projekt_IO
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        // Ta funkcja przesuwa okienko :)
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        /// <summary>
        /// Odtwarza dźwięk kliknięcia, jeśli dźwięk nie jest wyciszony
        /// </summary>
        private void sound(object sender, RoutedEventArgs e)
        {
            if (!AudioManager.IsMuted())
            {
                string soundPath = "Images/click.wav";
                AudioManager.PlaySound(soundPath);
            }
        }
    }
}
