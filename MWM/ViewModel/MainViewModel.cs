using Projekt_IO.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_IO.MWM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand SmartSunViewCommand { get; set; }
        public RelayCommand OgrodViewCommand { get; set; }

        public RelayCommand PogodaViewCommand { get; set; }
        public RelayCommand UstawieniaViewCommand { get; set; }


        public SmartSunViewModel SmartSunVm { get; set; }
        public OgrodViewModel OgrodVm { get; set; }

        public PogodaViewModel PogodaVm { get; set; }
        public UstawieniaViewModel UstawieniaVm { get; set; }

        private object _currentWindow;

        public object CurrentView
        {
            get { return _currentWindow;  }
            set
            {
                _currentWindow = value;
                onPropertyChanged();
            }
        }


        public MainViewModel()
        {
            SmartSunVm = new SmartSunViewModel();
            OgrodVm = new OgrodViewModel();
            PogodaVm = new PogodaViewModel();
            UstawieniaVm = new UstawieniaViewModel();

            CurrentView = SmartSunVm;

            SmartSunViewCommand = new RelayCommand(o =>
            {
                CurrentView = SmartSunVm;
            });

            OgrodViewCommand = new RelayCommand(o =>
            {
                CurrentView = OgrodVm;
            });

            PogodaViewCommand = new RelayCommand(o =>
            {
                CurrentView = PogodaVm;
            });

            UstawieniaViewCommand = new RelayCommand(o =>
            {
                CurrentView = UstawieniaVm;
            });
        }
    }
}

