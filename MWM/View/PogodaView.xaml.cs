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
using Projekt_IO.MWM.ViewModel;

namespace Projekt_IO.MWM.View
{
    /// <summary>
    /// Logika interakcji dla klasy PogodaView.xaml
    /// </summary>
    public partial class PogodaView : UserControl
    {
        public PogodaView()
        {
            InitializeComponent();

            this.DataContext = new PogodaViewModel();
        }
    }
}
