using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Projekt_IO.MWM.View
{
    public partial class OgrodView : UserControl
    {
        private const int MaxPlants = 6;

        public OgrodView()
        {
            InitializeComponent();
        }

        private void OpenPairingWindow_Click(object sender, RoutedEventArgs e)
        {
            var pairingWindow = new Pairing();

            pairingWindow.Owner = Application.Current.MainWindow;

            pairingWindow.ShowDialog();
        }

        private void AddPlantButton_Click(object sender, RoutedEventArgs e)
        {
            AddPlant dialog = new AddPlant();
            if (dialog.ShowDialog() == true)
            {
                StackPanel plantItem = new StackPanel() { Width = 120, Margin = new Thickness(10) };
                Image image = new Image() { Width = 100, Height = 100 };

                image.Source = dialog.PlantImage ?? new BitmapImage(new Uri("/Images/rose.png"));

                TextBlock name = new TextBlock()
                {
                    Text = dialog.PlantName,
                    TextAlignment = TextAlignment.Center,
                    Margin = new Thickness(0, 5, 0, 0)
                };

                plantItem.Children.Add(image);
                plantItem.Children.Add(name);

                if (PlantPanel.Children.Count < MaxPlants)
                {
                    PlantPanel.Children.Add(plantItem);
                }
                else
                {
                    MessageBox.Show("Możesz dodać maksymalnie 6 roślin!", "Ostrzeżenie", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }
    }
}
