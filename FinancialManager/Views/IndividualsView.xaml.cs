using FinancialManager.ViewModels;
using System.Windows.Controls;

namespace FinancialManager.Views
{
    /// <summary>
    /// Interaction logic for IndividualsView.xaml
    /// </summary>
    public partial class IndividualsView : UserControl
    {
        public IndividualsView()
        {
            InitializeComponent();
            DataContext = new IndividualsViewModel();
        }
    }
}
