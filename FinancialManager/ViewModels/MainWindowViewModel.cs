using FinancialManager.Views;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace FinancialManager.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private UserControl _homeView;
        private UserControl _currentView;
        private UserControl _individualView;
        private UserControl _companyView;
        private UserControl _addTransactionView;
        private UserControl _detailsTransactionView;
        private UserControl _addBankBalanceView;
        private UserControl _detailsBankBalanceView;
        private UserControl _dashboardView;

        public MainWindowViewModel()
        {
            GetTime();
            LoadHomeCommand = new DelegateCommand(LoadHome);
            LoadIndividualCommand = new DelegateCommand(LoadIndividual);
            LoadCompanyCommand = new DelegateCommand(LoadCompany);
            LoadAddTransationCommand = new DelegateCommand(LoadAddTransation);
            LoadDetailsTransationCommand = new DelegateCommand(LoadDetailsTransation);
            LoadAddBankBalanceCommand = new DelegateCommand(LoadAddBankBalance);
            LoadDetailsBankBalanceCommand = new DelegateCommand(LoadDetailsBankBalance);
            LoadDashboardCommand = new DelegateCommand(LoadDashboard);
            LoadExitCommand = new DelegateCommand(LoadExit);
        }
        private void GetTime()
        {
            // Start a timer to update the CurrentTime property every second
            var timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += (sender, args) => CurrentTime = DateTime.Now.ToString();
            timer.Start();
        }
        private string _currentTime;

        public string CurrentTime
        {
            get { return _currentTime; }
            set { SetProperty(ref _currentTime, value); }
        }
        public UserControl HomeView
        {
            get { return _homeView; }
            set { SetProperty(ref _homeView, value); }
        }
        public UserControl CurrentView
        {
            get { return _currentView; }
            set { SetProperty(ref _currentView, value); }
        }


        public UserControl IndividualView
        {
            get { return _individualView; }
            set { SetProperty(ref _individualView, value); }
        }

        public UserControl CompanyView
        {
            get { return _companyView; }
            set { SetProperty(ref _companyView, value); }
        }

        public UserControl AddTransactionView
        {
            get { return _addTransactionView; }
            set { SetProperty(ref _addTransactionView, value); }
        }

        public UserControl DetailsTransactionView
        {
            get { return _detailsTransactionView; }
            set { SetProperty(ref _detailsTransactionView, value); }
        }

        public UserControl AddBankBalanceView
        {
            get { return _addBankBalanceView; }
            set { SetProperty(ref _addBankBalanceView, value); }
        }

        public UserControl DetailsBankBalanceView
        {
            get { return _detailsBankBalanceView; }
            set { SetProperty(ref _detailsBankBalanceView, value); }
        }

        public UserControl DashboardView
        {
            get { return _dashboardView; }
            set { SetProperty(ref _dashboardView, value); }
        }



        public DelegateCommand LoadHomeCommand { get; }
        public DelegateCommand LoadIndividualCommand { get; }
        public DelegateCommand LoadCompanyCommand { get; }
        public DelegateCommand LoadAddTransationCommand { get; }
        public DelegateCommand LoadDetailsTransationCommand { get; }
        public DelegateCommand LoadAddBankBalanceCommand { get; }
        public DelegateCommand LoadDetailsBankBalanceCommand { get; }
        public DelegateCommand LoadDashboardCommand { get; }
        public DelegateCommand LoadExitCommand { get; }

        private void LoadHome()
        {
            CurrentView = new HomeView();
        }

        private void LoadIndividual()
        {
            CurrentView = new IndividualsView();
        }

        private void LoadCompany()
        {
            CurrentView = new CompanyView();
        }

        private void LoadAddTransation()
        {
            CurrentView = new AddTransactionView();
        }

        private void LoadDetailsTransation()
        {
            CurrentView = new DetailsTransactionView();
        }

        private void LoadAddBankBalance()
        {
            CurrentView = new AddBankBalanceView();
        }

        private void LoadDetailsBankBalance()
        {
            CurrentView = new DetailsBankBalanceView();
        }

        private void LoadDashboard()
        {
            CurrentView = new DashboardView();
        }

        private void LoadExit()
        {
            Application.Current.Shutdown();
        }
    }
}
