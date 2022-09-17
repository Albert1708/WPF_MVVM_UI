using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_MVVM_UI.Core;

namespace WPF_MVVM_UI.MVVM.ViewModel
{
    class MainViewModel : observableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand ProductViewCommand { get; set; }


        private object _currentView;
        public HomeViewModel HomeVM { get; set; }
        public ProductViewModel ProVM { get; set; }

        public object currentView
        {
            get { return _currentView; }
            set { _currentView = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            ProVM = new ProductViewModel();
            currentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                currentView = HomeVM;
            });

            ProductViewCommand = new RelayCommand(o =>
            {
                currentView = ProVM;
            });
        }
    }
}
