using FinancialManager.ViewModels;
using System.Windows.Controls;

namespace FinancialManager.Views
{
    /// <summary>
    /// Interaction logic for IndividualDetailsView.xaml
    /// </summary>
    public partial class IndividualDetailsView : UserControl
    {
        public IndividualDetailsView()
        {
            InitializeComponent();
            DataContext = new IndividualDetailsViewModel();
        }
    }
}
