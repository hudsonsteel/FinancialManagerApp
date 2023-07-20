using FinancialManager.ViewModels;
using System.Windows.Controls;

namespace FinancialManager.Views
{
    /// <summary>
    /// Interaction logic for IndividualsView.xaml
    /// </summary>
    public partial class UserView : UserControl
    {
        public UserView()
        {
            InitializeComponent();
            DataContext = new UsersViewModel();
        }
    }
}
