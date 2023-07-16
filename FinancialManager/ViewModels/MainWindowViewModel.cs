using FinancialManager.Views;
using Prism.Commands;
using Prism.Mvvm;
using System.Windows.Controls;

namespace FinancialManager.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public MainWindowViewModel()
        {
            LoadHomeCommand = new DelegateCommand(LoadHome);
        }

        private UserControl _homeView;

        public UserControl HomeView
        {
            get { return _homeView; }
            set { SetProperty(ref _homeView, value); }
        }
        public DelegateCommand LoadHomeCommand { get; }

        private void LoadHome()
        {
            HomeView = new HomeView();
        }
    }
}
