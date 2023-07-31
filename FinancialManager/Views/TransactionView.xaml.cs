using FinancialManager.ViewModels;
using System.Windows.Controls;
using System.Windows.Input;

namespace FinancialManager.Views
{
    /// <summary>
    /// Interaction logic for TransactionView.xaml
    /// </summary>
    public partial class TransactionView : UserControl
    {
        public TransactionView()
        {
            InitializeComponent();
            DataContext = new TransactionViewModel();
        }
        private void OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Allow only numbers (0-9) as input
            e.Handled = !IsNumericInput(e.Text);
        }

        private bool IsNumericInput(string text)
        {
            // Use regular expression to check if the input text contains only numbers
            return System.Text.RegularExpressions.Regex.IsMatch(text, "^[0-9]+$");
        }
    }
}
