using System;
using Dostoevsci.Core;

namespace Dostoevsci.MVVM.ViewModel
{
    class MainViewModel : Class1
    {

        public RealyCommand HomeViewCommand { get; set; }
        public RealyCommand DiscoveryViewCommand { get; set; }
        public RealyCommand FeaturedViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public DiscoveryViewModel DiscoveryVM { get; set; }
        public FeaturedViewModel FeaturedVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            DiscoveryVM = new DiscoveryViewModel();
            FeaturedVM = new FeaturedViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RealyCommand(o => 
            {
                CurrentView = HomeVM;
            });

            DiscoveryViewCommand = new RealyCommand(o =>
            {
                CurrentView = DiscoveryVM;
            });

            FeaturedViewCommand = new RealyCommand(o =>
            {
                CurrentView = FeaturedVM;
            });
        }
    }
}
