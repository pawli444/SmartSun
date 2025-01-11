using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
using Projekt_IO.Services;

namespace Projekt_IO.MWM.View
{
    /// <summary>
    /// Logika interakcji dla klasy SmartSunView.xaml
    /// </summary>
    public partial class SmartSunView : UserControl
    {
        public SmartSunView()
        {
            InitializeComponent();
        }

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
