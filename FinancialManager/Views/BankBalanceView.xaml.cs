using FinancialManager.ViewModels;
using System.Windows.Controls;

namespace FinancialManager.Views
{
    /// <summary>
    /// Interaction logic for AddBankBalanceView.xaml
    /// </summary>
    public partial class BankBalanceView : UserControl
    {
        public BankBalanceView()
        {
            DataContext = new BankBalanceViewModel();
            InitializeComponent();
        }
    }
}
