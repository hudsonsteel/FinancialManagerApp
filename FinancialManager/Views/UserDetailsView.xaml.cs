using FinancialManager.ViewModels;
using System.Windows.Controls;

namespace FinancialManager.Views
{
    /// <summary>
    /// Interaction logic for UserDetailsView.xaml
    /// </summary>
    public partial class UserDetailsView : UserControl
    {
        public UserDetailsView()
        {
            InitializeComponent();
            DataContext = new UserDetailsViewModel();
        }
    }
}
