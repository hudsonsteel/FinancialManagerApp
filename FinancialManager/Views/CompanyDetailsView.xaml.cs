using FinancialManager.ViewModels;
using System.Windows.Controls;

namespace FinancialManager.Views
{
    /// <summary>
    /// Interaction logic for CompanyDetailsView.xaml
    /// </summary>
    public partial class CompanyDetailsView : UserControl
    {
        public CompanyDetailsView()
        {
            DataContext = new CompanyDetailsViewModel();
            InitializeComponent();
        }
    }
}
