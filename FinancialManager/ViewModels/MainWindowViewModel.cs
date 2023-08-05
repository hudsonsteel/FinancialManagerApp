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
        private UserControl _userView;
        private UserControl _companyView;
        private UserControl _transactionView;
        private UserControl _detailsTransactionView;
        private UserControl _addBankBalanceView;
        private UserControl _detailsBankBalanceView;
        private UserControl _dashboardView;

        public MainWindowViewModel()
        {
            GetTime();
            LoadHomeCommand = new DelegateCommand(LoadHome);
            LoadUserCommand = new DelegateCommand(LoadUser);
            LoadUserDetailsCommand = new DelegateCommand(LoadUserDetails);
            LoadCompanyCommand = new DelegateCommand(LoadCompany);
            LoadCompanyDetailsCommand = new DelegateCommand(LoadCompanyDetails);
            LoadAddTransationCommand = new DelegateCommand(LoadTransation);
            LoadTransationDetailsCommand = new DelegateCommand(LoadDetailsTransation);
            LoadBankBalanceCommand = new DelegateCommand(LoadBankBalance);
            LoadBankBalanceDetailsCommand = new DelegateCommand(LoadDetailsBankBalance);
            LoadDashboardCommand = new DelegateCommand(LoadDashboard);
            LoadAboutCommand = new DelegateCommand(LoadAbout);
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


        public UserControl UserView
        {
            get { return _userView; }
            set { SetProperty(ref _userView, value); }
        }

        public UserControl CompanyView
        {
            get { return _companyView; }
            set { SetProperty(ref _companyView, value); }
        }

        public UserControl TransactionView
        {
            get { return _transactionView; }
            set { SetProperty(ref _transactionView, value); }
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
        public DelegateCommand LoadUserCommand { get; }
        public DelegateCommand LoadCompanyCommand { get; }
        public DelegateCommand LoadCompanyDetailsCommand { get; }
        public DelegateCommand LoadAddTransationCommand { get; }
        public DelegateCommand LoadUserDetailsCommand { get; }
        public DelegateCommand LoadTransationDetailsCommand { get; }
        public DelegateCommand LoadBankBalanceCommand { get; }
        public DelegateCommand LoadBankBalanceDetailsCommand { get; }
        public DelegateCommand LoadDashboardCommand { get; }
        public DelegateCommand LoadAboutCommand { get; }
        public DelegateCommand LoadExitCommand { get; }

        private void LoadHome()
        {
            CurrentView = new HomeView();
        }

        private void LoadUser()
        {
            CurrentView = new UserView();
        }
        private void LoadUserDetails()
        {
            CurrentView = new UserDetailsView();
        }

        private void LoadCompany()
        {
            CurrentView = new CompanyView();
        }

        private void LoadTransation()
        {
            CurrentView = new TransactionView();
        }

        private void LoadDetailsTransation()
        {
            CurrentView = new TransactionDetailsView();
        }

        private void LoadBankBalance()
        {
            CurrentView = new BankBalanceView();
        }

        private void LoadDetailsBankBalance()
        {
            CurrentView = new BankBalanceDetailsView();
        }

        private void LoadDashboard()
        {
            CurrentView = new DashboardView();
        }
        private void LoadCompanyDetails()
        {
            CurrentView = new CompanyDetailsView();
        }
        private void LoadAbout()
        {
            CurrentView = new AboutView();
        }
        private void LoadExit()
        {
            Application.Current.Shutdown();
        }
    }
}
