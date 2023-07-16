using FinancialManager.ViewModels;
using Prism.Commands;
using System.Windows.Controls;

namespace FinancialManager.Views
{
    /// <summary>
    /// Interaction logic for AdressView.xaml
    /// </summary>
    public partial class AdressView : UserControl
    {
        public AdressView(DelegateCommand saveCommand)
        {
            InitializeComponent();
            DataContext = new AdressViewModel(saveCommand);
        }

        public AdressViewModel ViewModel => (AdressViewModel)DataContext;
    }
}
