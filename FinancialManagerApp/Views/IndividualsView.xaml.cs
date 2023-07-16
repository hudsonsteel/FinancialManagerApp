using FinancialManagerApp.ViewModels;
using System.Windows.Controls;

namespace FinancialManagerApp.Views
{
    /// <summary>
    /// Interaction logic for IndividualsView.xaml
    /// </summary>
    public partial class IndividualsView : UserControl
    {
        public IndividualsView()
        {
            DataContext = new IndividualsViewModel();
            InitializeComponent();
        }

    }
}
