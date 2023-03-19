using MOFUI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MOFUI.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand TasksViewCommand { get; set; }


        public HomeViewModel HomeVM { get; set; }
        public TasksViewModel TasksVM { get; set; } 

        private object _currentView;

        public object CurrentView { 
            get { return _currentView; } 
            set {
                _currentView = value;
                OnPropertyChanged(); 
            } 
        }


        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            TasksVM = new TasksViewModel();
            
            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(x =>
            {
                CurrentView= HomeVM;
            });
            TasksViewCommand = new RelayCommand(x =>
            {
                CurrentView = TasksVM;
            });
        }
    }
}
