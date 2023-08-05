using FinancialManager.ViewModels;
using System.Windows.Controls;

namespace FinancialManager.Views
{
    /// <summary>
    /// Interaction logic for DetailsBankBalanceView.xaml
    /// </summary>
    public partial class BankBalanceDetailsView : UserControl
    {
        public BankBalanceDetailsView()
        {
            DataContext = new BankBalanceDetailsViewModel();
            InitializeComponent();
        }
    }
}
